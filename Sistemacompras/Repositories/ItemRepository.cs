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
    class ItemRepository
    {
        private PurchaseContext _Context;

        public ItemRepository()
        {
            _Context = new PurchaseContext();
        }

        public Item Get(int id)
        {
            return _Context.Items
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Item> GetAll()
        {
            return _Context.Items
                .Where(x => x.StatusId != (int)StatusEnum.Inactive)
                .ToList();
        }

        public Item Create(Item data)
        {
            Item newItem = new Item();


            return newItem;
        }

        public Item Update(Item data)
        {
            if (data?.Id != null)
            {
                Item Item = _Context.Items
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                Item = data;
                return Item;
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

                Item.StatusId = (int)StatusEnum.Inactive;
                return Item.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
