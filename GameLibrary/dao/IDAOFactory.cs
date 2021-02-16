using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.dao
{
    interface IDAOFactory
    {
        IAccumulatorDAO GetAccumulatorDAO();
        IDisksDAO GetDisksDAO();
        IEngineDAO GetEngineDAO();
        ICarDAO GetCarDao();
    }
}
