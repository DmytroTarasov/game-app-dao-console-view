using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IAbstractDAO<T>
    {
        T Get(Guid id);
        void Insert(T entity);
        void Update(Guid id, T entity);
        void Delete(Guid id);
        List<T> findAll();
    }
}
