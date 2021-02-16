using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class CarDAO : AbstractDAO<Car>, ICarDAO
    {
        public CarDAO(Database database) : base(database.Cars, database) { }
    }
}
