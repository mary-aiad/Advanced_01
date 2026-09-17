using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_01
{
    internal interface IRepository<T>
    {
        void Add(T entity);
        T GetByID(int id);
        void Update(T entity);
        void Delete(int id);
    }
}
