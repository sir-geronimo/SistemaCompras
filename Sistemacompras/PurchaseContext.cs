using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistemacompras.Entities;
using Sistemacompras.Contracts;
using System.Data.Entity.Infrastructure;

namespace Sistemacompras
{
    class PurchaseContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemRequest> ItemRequests { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries<IAuditableEntity>();

            if (entities.Count() > 0)
            {
                DateTime now = DateTime.Now;

                foreach (var entity in entities.Where(x =>
                    x.State == EntityState.Added || x.State == EntityState.Modified))
                {
                    if (entity.State == EntityState.Added)
                    {
                        entity.Entity.CreatedDate = now;
                        entity.Entity.CreatedBy = 1;
                    }

                    entity.Entity.UpdatedDate = now;
                    entity.Entity.UpdatedBy = 1;
                }
            }

            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                return base.SaveChanges();
            }
        }
    }
}
