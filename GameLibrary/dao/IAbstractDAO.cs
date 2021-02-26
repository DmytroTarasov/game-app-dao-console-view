using System;
using System.Collections.Generic;

namespace GameLibrary
{
    public interface IAbstractDAO<T> 
    {
        T Get(Guid id);
        void Insert(T entity);
        void Update(Guid id, T entity);
        void Delete(Guid id);
        List<T> FindAll();
    }
}
