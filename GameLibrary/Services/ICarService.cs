using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Services
{
    interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(Guid id);
        void CreateCar(int speed, Engine engine, Accumulator accumulator, Disks disks, double money);
        void StartMove(Car car);
        void StopMove(Car car, Stopwatch stopwatch);
        void increaseDistance(Car car, Stopwatch stopwatch);

    }
}
