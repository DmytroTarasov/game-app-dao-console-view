using GameLibrary.daoImpl;
using GameLibrary.Model;
using System;
using System.Collections.Generic;

namespace GameLibrary
{
    public class Database
    {
        internal IDictionary<Guid, Car> Cars;

        internal IDictionary<Guid, Detail> Details;
        public Database()
        {
            Cars = new Dictionary<Guid, Car>();
            Details = new Dictionary<Guid, Detail>();
        }
        public DAOFactory GetDAOFactory()
        {
            return new DAOFactory(this);
        }
    }
}
