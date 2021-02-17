using GameLibrary.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class CarDAO : AbstractDAO<Car>, ICarDAO
    {
        public CarDAO(Database database) : base(database.Cars, database) { }

        public double CreateCar(int speed, Engine engine, Accumulator accumulator, Disks disks, double money)
        {
            Car car = new Car(speed, engine, accumulator, disks);
            money = money - (engine.PurchaseCost + accumulator.PurchaseCost + disks.PurchaseCost);
            Insert(car);
            return money;
        }
        //public void StartMove(Car car)
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    if (stopwatch.ElapsedMilliseconds / 1000 == 2)
        //    {
        //        if (CheckDetails(car))
        //        {
        //            StopMove(car, stopwatch); // остановиться
        //                                      // RepairDetail() need repair
        //        }
        //        IncreaseMileage(car, stopwatch);
        //        StartMove(car);
        //    }
        //}

        //public void StopMove()
        //{
        //    throw new NotImplementedException();
        //}


    }
}
