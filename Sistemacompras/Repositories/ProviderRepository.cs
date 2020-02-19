using Sistemacompras.Contracts;
using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using System.Collections.Generic;
using System.Linq;

namespace Sistemacompras.Repositories
{
    class ProviderRepository : IRepository<Provider, ProviderDto>
    {
        private readonly PurchaseContext _Context;

        public ProviderRepository()
        {
            _Context = new PurchaseContext();
        }

        public ProviderDto Get(int id)
        {
            return _Context.Providers
                .Where(x => x.Id == id)
                .Select(x => new ProviderDto
                {
                    Id = x.Id,
                    Identification = x.Identification,
                    Name = x.Name,
                    PublicName = x.PublicName,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .FirstOrDefault();
        }

        public IEnumerable<ProviderDto> GetAll()
        {
            return _Context.Providers
                .Where(x => x.StatusId == (int)StatusEnum.Inactive
                    || x.StatusId == (int)StatusEnum.Active
                )
                .Select(x => new ProviderDto
                {
                    Id = x.Id,
                    Identification = x.Identification,
                    Name = x.Name,
                    PublicName = x.PublicName,
                    Status = x.Status.Name,
                    CreatedDate = x.CreatedDate
                })
                .ToList();
        }

        public ProviderDto Create(Provider data)
        {
            Provider item = _Context.Providers.Add(data);
            _Context.SaveChanges();

            return Get(item.Id);
        }

        public ProviderDto Update(Provider data)
        {
            if (data.Id > 0)
            {
                Provider provider = _Context.Providers
                    .Where(x => x.Id == data.Id)
                    .FirstOrDefault();

                provider.Identification = data.Identification;
                provider.Name = data.Name;
                provider.PublicName = data.PublicName;
                provider.StatusId = data.StatusId;
                _Context.SaveChanges();

                return Get(provider.Id);
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
                Provider provider = _Context.Providers
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

                provider.StatusId = (int)StatusEnum.Deleted;
                _Context.SaveChanges();

                return provider.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
