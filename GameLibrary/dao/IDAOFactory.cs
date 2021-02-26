using GameLibrary.daoImpl;

namespace GameLibrary.dao
{
    public interface IDAOFactory
    {
        DetailDAO GetDetailDao();
        CarDAO GetCarDao();
    }
}
