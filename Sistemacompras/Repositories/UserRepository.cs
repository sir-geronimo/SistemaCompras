using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using Sistemacompras.Dto;

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
                    Status = x.Status.Name
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
                    Status = x.Status.Name
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
            if (data?.Id != null)
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
                return user.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
