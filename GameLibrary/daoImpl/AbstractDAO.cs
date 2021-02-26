using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.daoImpl
{
    public class AbstractDAO<T> : IAbstractDAO<T> 
    {
        protected IDictionary<Guid, T> Entities;
        protected Database Database;

        public AbstractDAO(IDictionary<Guid, T> entities, Database database)
        {
            Entities = entities;
            Database = database;
        }
        public T Get(Guid id) 
        {
            return Entities.Where(entity => entity.Key == id).FirstOrDefault().Value;
        }

        public void Insert(T entity) 
        {
            Entities.Add(((IBase)entity).Id, entity);
        }

        public void Update(Guid id, T entity)
        {
            foreach (Guid Id in Entities.Keys)
            {
                if (Id == id)
                {
                    Entities[Id] = entity;
                }
            }
        }
        public void Delete(Guid id) 
        {
            foreach (Guid Id in Entities.Keys)
            {
                if (Id == id)
                {
                    Entities.Remove(Id);
                }
            }
        }
        public List<T> FindAll() 
        {
            return Entities.Values.ToList();
        }
    }
}
