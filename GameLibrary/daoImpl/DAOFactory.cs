using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class DAOFactory : IDAOFactory
    {
        protected Database Database;
        protected IDetailDAO DetailDAO;
        protected ICarDAO CarDAO;
        public DAOFactory(Database database)
        {
            Database = database;
            DetailDAO = new DetailDAO(database);
            CarDAO = new CarDAO(database);
        }

        public IDetailDAO GetDetailDAO()
        {
            return DetailDAO;
        }

        public ICarDAO GetCarDao()
        {
            return CarDAO;
        }
    }
}
