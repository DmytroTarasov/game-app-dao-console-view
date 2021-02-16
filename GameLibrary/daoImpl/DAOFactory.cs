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
        protected IEngineDAO EngineDAO;
        protected IAccumulatorDAO AccumulatorDAO;
        protected IDisksDAO DisksDAO;
        protected ICarDAO CarDAO;

        public DAOFactory(Database database)
        {
            Database = database;

            EngineDAO = new EngineDAO(database);
            AccumulatorDAO = new AccumulatorDAO(database);
            DisksDAO = new DisksDAO(database);
            CarDAO = new CarDAO(database);
        }

        public IAccumulatorDAO GetAccumulatorDAO()
        {
            return AccumulatorDAO;
        }

        public ICarDAO GetCarDao()
        {
            return CarDAO;
        }

        public IDisksDAO GetDisksDAO()
        {
            return DisksDAO;
        }

        public IEngineDAO GetEngineDAO()
        {
            return EngineDAO;
        }
    }
}
