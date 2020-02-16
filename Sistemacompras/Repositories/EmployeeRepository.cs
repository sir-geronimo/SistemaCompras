using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using Sistemacompras.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistemacompras.Repositories
{
    class EmployeeRepository : IRepository<Employee, EmployeeDto>
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
                .Select(x => new EmployeeDto
                {
                    Id = x.Id,
                    Identification = x.User.Identification,
                    Name = x.User.Name,
                    Department = x.Department.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            return _Context.Employees
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new EmployeeDto
                {
                    Id = x.Id,
                    Identification = x.User.Identification,
                    Name = x.User.Name,
                    Department = x.Department.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public EmployeeDto Create(Employee data)
        {
            Employee item = _Context.Employees.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public EmployeeDto Update(Employee data)
        {
            if (data?.Id != null)
            {
                Employee employee = _Context.Employees
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                employee.UserId = data.UserId;
                employee.DepartmentId = data.DepartmentId;
                employee.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(employee.Id);
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
                Employee employee = _Context.Employees
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                employee.StatusId = (int)StatusEnum.Deleted;
                _Context.SaveChanges();

                return employee.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
