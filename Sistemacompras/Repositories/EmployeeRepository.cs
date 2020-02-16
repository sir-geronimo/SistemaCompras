using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistemacompras.Repositories
{
    class EmployeeRepository
    {
        private PurchaseContext _Context;

        public EmployeeRepository()
        {
            _Context = new PurchaseContext();
        }

        public EmployeeDto Get(int id)
        {
            return _Context.Employees
                .Where(x => x.Id == id)
                .Include(x => x.User)
                .Include(x => x.Department)
                .Select(x => new EmployeeDto
                {
                    Id = x.Id,
                    Name = x.User.Name,
                    Department = x.Department.Name,
                    Status = x.Status.Name
                })
                .FirstOrDefault();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            return _Context.Employees
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Include(x => x.User)
                .Include(x => x.Department)
                .Select(x => new EmployeeDto
                {
                    Id = x.Id,
                    Name = x.User.Name,
                    Department = x.Department.Name,
                    Status = x.Status.Name
                })
                .ToList();
        }

        public Employee Create(Employee data)
        {
            Employee item = _Context.Employees.Add(data);
            _Context.SaveChanges();

            return item;
        }

        public Employee Update(Employee data)
        {
            if (data?.Id != null)
            {
                Employee Employee = _Context.Employees
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                Employee = data;
                _Context.SaveChanges();

                return Employee;
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
                Employee Employee = _Context.Employees
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                Employee.StatusId = (int)StatusEnum.Deleted;
                _Context.SaveChanges();

                return Employee.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
