using GameLibrary.daoImpl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using GameLibrary.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Model;
using System.Reflection;

namespace GameLibrary.Services
{
    class CarServiceImpl : ICarService
    {
        DAOFactory DaoFactory;
        DetailServiceImpl DetailServiceImpl;
        public CarServiceImpl(DAOFactory daoFactory, DetailServiceImpl detailServiceImpl)
        {
            DaoFactory = daoFactory;
            DetailServiceImpl = detailServiceImpl;
        }
        public List<Car> GetAllCars()
        {
            return DaoFactory.GetCarDao().FindAll();
        }
        public Car GetCarById(Guid id)
        {
            return DaoFactory.GetCarDao().Get(id);
        }
        public void StartMove(Car car)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (stopwatch.ElapsedMilliseconds / 1000 == 2)
            {
                stopwatch.Stop();
                DetailServiceImpl.CheckDetail(car.Accumulator);
                DetailServiceImpl.CheckDetail(car.Disks);
                DetailServiceImpl.CheckDetail(car.Engine);
                if (car.Accumulator.IsBroken || car.Disks.IsBroken || car.Engine.IsBroken)
                {
                    StopMove(car, stopwatch); // остановиться
                    // RepairDetail() need repair
                }
                IncreaseMileage(car, stopwatch);
                StartMove(car);
            }
        }

        public void StartMove(Car car)
        {
  
        }
        public void StopMove(Car car, Stopwatch stopwatch)
        {
            stopwatch.Stop();
            IncreaseMileage(car, stopwatch);
        }
        public void IncreaseMileage(Car car, Stopwatch stopwatch)
        {
            car.Mileage += (car.Speed * 1000 / (60 * 60 * 1000)) * stopwatch.ElapsedMilliseconds; // distance that was drived 
        }
        //public bool CheckDetails(Car car)
        //{
        //    double r = Convert.ToDouble(new Random().Next(1));
        //    if (r > car.Accumulator.StabilityInOperation ||  r > car.Engine.StabilityInOperation || 
        //        r > car.Disks.StabilityInOperation)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
