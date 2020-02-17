using System.Collections.Generic;

namespace Sistemacompras.Contracts
{
    interface IRepository<T, R> where T : class
    {
        R Get(int Id);
        IEnumerable<R> GetAll();
        R Create(T data);
        R Update(T data);
        int Delete(int Id);
    }
}
