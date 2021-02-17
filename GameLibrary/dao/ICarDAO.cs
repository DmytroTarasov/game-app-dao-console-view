using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.dao
{
    interface ICarDAO : IAbstractDAO<Car>
    {
        double CreateCar(int speed, Engine engine, Accumulator accumulator, Disks disks, double money);

    }
}
