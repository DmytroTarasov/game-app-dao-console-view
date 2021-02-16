using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class AbstractDAO<T> : IAbstractDAO<T> where T : IBase
    {
        protected IDictionary<Guid, T> entities;
        protected Database database;

        public AbstractDAO(IDictionary<Guid, T> entities, Database database)
        {
            this.entities = entities;
            this.database = database;
        }
        public T Get(Guid id) // Correct 
        {
            return entities.Where(entity => entity.Key == id).FirstOrDefault().Value;
        }

        public void Insert(T entity) // ? 
        {
            entities.Add(entity.Id, entity);
        }

        public void Update(Guid id, T entity) // Correct
        {
            foreach (Guid Id in entities.Keys)
            {
                if (Id == id)
                {
                    entities[Id] = entity;
                }
            }
        }
        public void Delete(Guid id) // Correct
        {
            foreach (Guid Id in entities.Keys)
            {
                if (Id == id)
                {
                    entities.Remove(Id);
                }
            }
        }
        public List<T> findAll() // Correct
        {
            return entities.Values.ToList();
        }
    }
}
