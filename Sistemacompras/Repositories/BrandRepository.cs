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
    class BrandRepository : IRepository<Brand, BrandDto>
    {
        private PurchaseContext _Context;

        public BrandRepository()
        {
            _Context = new PurchaseContext();
        }

        public BrandDto Get(int id)
        {
            return _Context.Brands
                .Where(x => x.Id == id)
                .Select(x => new BrandDto
                {
                    Id = x.Id,
                    Description = x.Description,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<BrandDto> GetAll()
        {
            return _Context.Brands
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new BrandDto
                {
                    Id = x.Id,
                    Description = x.Description,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public BrandDto Create(Brand data)
        {
            Brand item = _Context.Brands.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public BrandDto Update(Brand data)
        {
            if (data?.Id != null)
            {
                Brand brand = _Context.Brands
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                brand.Description = data.Description;
                brand.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(brand.Id);
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

                brand.StatusId = (int)StatusEnum.Deleted;
                return brand.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
