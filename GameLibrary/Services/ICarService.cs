using System;
using System.Collections.Generic;

namespace GameLibrary.Services
{
    interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(Guid id);
        (double, Car) CreateCar(Engine engine, Accumulator accumulator, Disks disks, 
                         double coeffEarnMoneyPerMetr, double money);
        void IncreaseMileage(Car car);
        double RiseMoney(Car car, double distance, double money);
    }
}
