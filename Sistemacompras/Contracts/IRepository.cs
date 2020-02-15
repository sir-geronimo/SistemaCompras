using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemacompras.Contracts
{
    interface IRepository<T> where T : class
    {
        T Get(int Id);
        IEnumerable<T> GetAll();
        T Create(T data);
        T Update(T data);
        int Delete(int Id);
    }
}
