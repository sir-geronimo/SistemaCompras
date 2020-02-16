using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;
using Sistemacompras.Entities;
using Sistemacompras.Enum;

namespace Sistemacompras.Repositories
{
    class DepartmentRepository : IRepository<Department>
    {
        private PurchaseContext _Context;

        public DepartmentRepository()
        {
            _Context = new PurchaseContext();
        }

        public Department Get(int id)
        {
            return _Context.Departments
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Department> GetAll()
        {
            return _Context.Departments
                .Where(x => x.StatusId != (int)StatusEnum.Inactive)
                .ToList();
        }

        public Department Create(Department data)
        {
            Department newDepartment = new Department();


            return newDepartment;
        }

        public Department Update(Department data)
        {
            if (data?.Id != null)
            {
                Department Department = _Context.Departments
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                Department = data;
                return Department;
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
                Department Department = _Context.Departments
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                Department.StatusId = (int)StatusEnum.Inactive;
                return Department.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
