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
    class BrandRepository : IRepository<Brand>
    {
        private PurchaseContext _Context;

        public BrandRepository()
        {
            _Context = new PurchaseContext();
        }

        public Brand Get(int id)
        {
            return _Context.Brands
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Brand> GetAll()
        {
            return _Context.Brands
                .Where(x => x.StatusId != (int)StatusEnum.Inactive)
                .ToList();
        }

        public Brand Create(Brand data)
        {
            Brand newBrand = new Brand();


            return newBrand;
        }

        public Brand Update(Brand data)
        {
            if (data?.Id != null)
            {
                Brand brand = _Context.Brands
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                brand = data;
                return brand;
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
                Brand brand = _Context.Brands
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                brand.StatusId = (int)StatusEnum.Inactive;
                return brand.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
