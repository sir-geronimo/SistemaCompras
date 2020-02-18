using Sistemacompras.Contracts;
using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Sistemacompras.Repositories
{
    class ItemRequestRepository : IRepository<ItemRequest, ItemRequestDto>
    {
        private PurchaseContext _Context;

        public ItemRequestRepository()
        {
            _Context = new PurchaseContext();
        }

        public ItemRequestDto Get(int id)
        {
            return _Context.ItemRequests
                .Where(x => x.Id == id)
                .Include(x => x.Employee)
                .Select(x => new ItemRequestDto
                {
                    Id = x.Id,
                    Employee = x.Employee.User.Name,
                    Date = x.Date,
                    Item = x.Item.Name,
                    Quantity = x.Quantity,
                    Unit = x.Unit.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<ItemRequestDto> GetAll()
        {
            return _Context.ItemRequests
                .Where(x => x.StatusId != (int)StatusEnum.Deleted)
                .Include(x => x.Employee)
                .Select(x => new ItemRequestDto
                {
                    Id = x.Id,
                    Employee = x.Employee.User.Name,
                    Date = x.Date,
                    Item = x.Item.Name,
                    Quantity = x.Quantity,
                    Unit = x.Unit.Name,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public ItemRequestDto Create(ItemRequest data)
        {
            ItemRequest item = _Context.ItemRequests.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public ItemRequestDto Update(ItemRequest data)
        {
            if (data.Id > 0)
            {
                ItemRequest item = _Context.ItemRequests
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();


                item.Id = data.Id;
                item.EmployeeId = data.EmployeeId;
                item.Date = data.Date;
                item.ItemId = data.ItemId;
                item.Quantity = data.Quantity;
                item.UnitId = data.UnitId;
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
                _Context.SaveChanges();

                return Item.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
