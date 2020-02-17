using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using Sistemacompras.Dto;
using System.Data.Entity;

namespace Sistemacompras.Repositories
{
    class DepartmentRepository: IRepository<Department, DepartmentDto>
    {
        private PurchaseContext _Context;

        public DepartmentRepository()
        {
            _Context = new PurchaseContext();
        }

        public DepartmentDto Get(int id)
        {
            return _Context.Departments
                .Where(x => x.Id == id)
                .Select(x => new DepartmentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<DepartmentDto> GetAll()
        {
            return _Context.Departments
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new DepartmentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public DepartmentDto Create(Department data)
        {
            Department item = _Context.Departments.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public DepartmentDto Update(Department data)
        {
            if (data.Id > 0)
            {
                Department department = _Context.Departments
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                if (department != null)
                {
                    department.Name = data.Name;
                    department.StatusId = data.StatusId;
                    _Context.SaveChanges();

                    return Get(department.Id);
                }
                else
                {
                    return null;
                }

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
                Department department = _Context.Departments
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                department.StatusId = (int)StatusEnum.Deleted;
                _Context.SaveChanges();

                return department.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
