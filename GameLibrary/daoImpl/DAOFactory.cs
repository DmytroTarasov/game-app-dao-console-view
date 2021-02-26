using GameLibrary.dao;

namespace GameLibrary.daoImpl
{
    public class DAOFactory : IDAOFactory
    {
        protected Database Database;
        protected DetailDAO DetailDAO { get; }
        protected CarDAO CarDAO { get; }
        public DAOFactory(Database database)
        {
            Database = database;
            DetailDAO = new DetailDAO(database);
            CarDAO = new CarDAO(database);
        }
        public DetailDAO GetDetailDao()
        {
            return DetailDAO;
        }
        public CarDAO GetCarDao()
        {
            return CarDAO;
        }
    }
}
