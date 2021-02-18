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
        public void CreateCar(int speed, Engine engine, Accumulator accumulator, Disks disks, double money)
        {
            DaoFactory.GetCarDao().CreateCar(speed, engine, accumulator, disks, money);
        }
        public void Move(Car car, double money)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (stopwatch.ElapsedMilliseconds / 1000 == 1)
            {
                stopwatch.Stop();
                double distance = IncreaseMileage(car, stopwatch);
                RiseMoney(car, distance, money);
                if (!DetailServiceImpl.CheckDetail(car.Accumulator, money) && !DetailServiceImpl.CheckDetail(car.Engine, money)
                    && !DetailServiceImpl.CheckDetail(car.Disks, money)) 
                { 
                    Move(car, money);
                }
            }
        }
        public double IncreaseMileage(Car car, Stopwatch stopwatch)
        {
            double distance = car.Speed * 1000 / (60 * 60 * 1000) * stopwatch.ElapsedMilliseconds; // distance that was drived 
            car.Mileage += distance;
            return distance;
        }
        public void RiseMoney(Car car, double distance, double money)
        {
            money += distance * car.CoeffEarnMoneyPerMetr;
        }
    }
}
