using Sistemacompras.Contracts;
using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemacompras.Repositories
{
    class UserRepository : IRepository<User, UserDto>
    {
        private PurchaseContext _Context;

        public UserRepository()
        {
            _Context = new PurchaseContext();
        }

        public UserDto Get(int id)
        {
            return _Context.Users
                .Where(x => x.Id == id)
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Username = x.Username,
                    Identification = x.Identification,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _Context.Users
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new UserDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Username = x.Username,
                    Identification = x.Identification,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public UserDto Create(User data)
        {
            User item = _Context.Users.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public UserDto Update(User data)
        {
            if (data.Id > 0)
            {
                User user = _Context.Users
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                user.Name = data.Name;
                user.Username = data.Username;
                user.Identification = data.Identification;
                user.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(user.Id);
            }
            else
            {
                return null;
            }
        }

        public int Delete(int id)
        {
            if (id > 0)
            {
                User user = _Context.Users
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                user.StatusId = (int)StatusEnum.Deleted;
                _Context.SaveChanges();

                return user.Id;
            }
            else
            {
                return 0;
            }
        }

        public bool Login(string username, string password)
        {
            var data = _Context.Users
                .Where(x => x.Username == username)
                .Select(x => new
                {
                    x.Username,
                    x.Password
                })
                .FirstOrDefault();

            if (data != null)
            {
                if (PasswordVerify(password, data.Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<User> Register(User user)
        {
            User existingUser = await _Context.Users
                .Where(x => x.Username == user.Username)
                .FirstOrDefaultAsync();

            try
            {

                if (existingUser == null)
                {
                    user.Password = PasswordHash(user.Password);
                    return _Context.Users.Add(user);
                }
                else
                {
                    throw new Exception("User already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        private string PasswordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GenerateSalt());
        }

        private bool PasswordVerify(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
    }
}