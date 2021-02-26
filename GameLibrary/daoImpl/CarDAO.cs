using GameLibrary.dao;

namespace GameLibrary.daoImpl
{
    public class CarDAO : AbstractDAO<Car>, ICarDAO
    {
        public CarDAO(Database database) : base(database.Cars, database) { }

        public (double, Car) CreateCar(Engine engine, Accumulator accumulator, Disks disks, 
            double coeffEarnMoneyPerMetr, double money)
        {
            if (money - (engine.PurchaseCost + accumulator.PurchaseCost + disks.PurchaseCost) >= 0)
            {
                Car car = new Car(engine, accumulator, disks, coeffEarnMoneyPerMetr);
                money = money - (engine.PurchaseCost + accumulator.PurchaseCost + disks.PurchaseCost);
                Insert(car);
                //foreach (var prop in car.GetType().GetProperties())
                //{
                //    if (prop.PropertyType.BaseType.Name.Contains("Detail"))
                //    {
                //        foreach (var prop1 in prop.PropertyType.BaseType.GetType().GetProperties())
                //        {
                //            if (prop1.Name == "Type")
                //            {
                //                prop.SetValue(prop.PropertyType.BaseType, "V12");
                //            }
                //        }
                //    }
                //}
                engine.Car = car;
                accumulator.Car = car;
                disks.Car = car;
                return (money, car);
            }
            return (-1, null);
        }
        public void IncreaseMileage(Car car)
        {
            car.Mileage += 25;
        }
        public double RiseMoney(Car car, double distance, double money)
        {
            money += distance * car.CoeffMoneyPerKilometer;
            return money;
        }
    }
}
