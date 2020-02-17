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
    class UnitRepository : IRepository<Unit, UnitDto>
    {
        private PurchaseContext _Context;

        public UnitRepository()
        {
            _Context = new PurchaseContext();
        }

        public UnitDto Get(int id)
        {
            return _Context.Units
                .Where(x => x.Id == id)
                .Select(x => new UnitDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<UnitDto> GetAll()
        {
            return _Context.Units
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new UnitDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public UnitDto Create(Unit data)
        {
            Unit item = _Context.Units.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public UnitDto Update(Unit data)
        {
            if (data.Id > 0)
            {
                Unit unit = _Context.Units
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                unit.Name = data.Name;
                unit.Description = data.Description;
                unit.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(unit.Id);
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
                Unit unit = _Context.Units
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                unit.StatusId = (int)StatusEnum.Deleted;
                return unit.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
