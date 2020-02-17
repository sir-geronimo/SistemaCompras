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
    class ItemRepository : IRepository<Item, ItemDto>
    {
        private PurchaseContext _Context;

        public ItemRepository()
        {
            _Context = new PurchaseContext();
        }

        public ItemDto Get(int id)
        {
            return _Context.Items
                .Where(x => x.Id == id)
                .Select(x => new ItemDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Brand = x.Brand.Name,
                    Unit = x.Unit.Name,
                    Stock = x.Stock,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<ItemDto> GetAll()
        {
            return _Context.Items
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new ItemDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Brand = x.Brand.Name,
                    Unit = x.Unit.Name,
                    Stock = x.Stock,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public ItemDto Create(Item data)
        {
            Item item = _Context.Items.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public ItemDto Update(Item data)
        {
            if (data.Id > 0)
            {
                Item item = _Context.Items
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                item.Name = data.Name;
                item.Description = data.Description;
                item.BrandId = data.BrandId;
                item.UnitId = data.UnitId;
                item.Stock = data.Stock;
                item.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(item.Id);
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
                Item Item = _Context.Items
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                Item.StatusId = (int)StatusEnum.Deleted;
                return Item.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
