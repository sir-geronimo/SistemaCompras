using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;

namespace Sistemacompras.Repositories
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly PurchaseContext _Context;
        private readonly DbSet<T> _table;

        public GenericRepository()
        {
            _Context = new PurchaseContext();
            _table = _Context.Set<T>();
        }

        public T Get(int id)
        {
            return _table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T Create(T data)
        {
            T entity = _table.Add(data);
            _Context.SaveChanges();

            return entity;
        }

        public T Update(T data)
        {
            T entity = _table.Attach(data);
            _Context.Entry(data).State = EntityState.Modified;
            _Context.SaveChanges();

            return entity;
        }

        public int Delete(int id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
            _Context.SaveChanges();

            return id;
        }
    }
}
