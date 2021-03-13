using GameLibrary.dao;
using GameLibrary.daoImpl;
using System;
using System.Collections.Generic;

namespace GameLibrary.Services
{
    public class CarServiceImpl : ICarService
    {
        IDAOFactory DaoFactory;
        public CarServiceImpl(IDAOFactory daoFactory)
        {
            DaoFactory = daoFactory;
        }
        public List<Car> GetAllCars()
        {
            return DaoFactory.GetCarDao().FindAll();
        }
        public Car GetCarById(Guid id)
        {
            return DaoFactory.GetCarDao().Get(id);
        }
        public (double, Car) CreateCar(Engine engine, Accumulator accumulator, Disks disks,
                              double coeffEarnMoneyPerMetr, double money)
        {
            return DaoFactory.GetCarDao().CreateCar(engine, accumulator, disks, coeffEarnMoneyPerMetr, money);
        }
        public void IncreaseMileage(Car car)
        {
            DaoFactory.GetCarDao().IncreaseMileage(car);
        }
        public double RiseMoney(Car car, double distance, double money)
        {
            return DaoFactory.GetCarDao().RiseMoney(car, distance, money);
        }
    }
}
