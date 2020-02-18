using Sistemacompras.Contracts;
using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Sistemacompras.Repositories
{
    class PurchaseOrderRepository : IRepository<PurchaseOrder, PurchaseOrderDto>
    {
        private PurchaseContext _Context;

        public PurchaseOrderRepository()
        {
            _Context = new PurchaseContext();
        }

        public PurchaseOrderDto Get(int id)
        {
            return _Context.PurchaseOrders
                .Where(x => x.Id == id)
                .Select(x => new PurchaseOrderDto
                {
                    Id = x.Id,
                    ItemRequest = x.ItemRequest.Id,
                    Date = x.Date,
                    Status = x.Status.Name,
                    Item = x.Item.Name,
                    Quantity = x.Quantity,
                    Unit = x.Unit.Name,
                    Brand = x.Brand.Name,
                    Price = x.Price,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<PurchaseOrderDto> GetAll()
        {
            return _Context.PurchaseOrders
                .Where(x => x.StatusId != (int)StatusEnum.Deleted)
                .Select(x => new PurchaseOrderDto
                {
                    Id = x.Id,
                    ItemRequest = x.ItemRequest.Id,
                    Date = x.Date,
                    Status = x.Status.Name,
                    Item = x.Item.Name,
                    Quantity = x.Quantity,
                    Unit = x.Unit.Name,
                    Brand = x.Brand.Name,
                    Price = x.Price,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public PurchaseOrderDto Create(PurchaseOrder data)
        {
            PurchaseOrder item = _Context.PurchaseOrders.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public PurchaseOrderDto Update(PurchaseOrder data)
        {
            if (data.Id > 0)
            {
                PurchaseOrder item = _Context.PurchaseOrders
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();


                item.Id = data.Id;
                item.ItemRequestId = data.ItemRequestId;
                item.Date = data.Date;
                item.StatusId = data.StatusId;
                item.ItemId = data.ItemId;
                item.Quantity = data.Quantity;
                item.UnitId = data.UnitId;
                item.BrandId = data.BrandId;
                item.Price = data.Price;
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
                PurchaseOrder Item = _Context.PurchaseOrders
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
