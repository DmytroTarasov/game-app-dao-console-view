namespace GameLibrary.dao
{
    public interface ICarDAO : IAbstractDAO<Car>
    {
        (double, Car) CreateCar(Engine engine, Accumulator accumulator, Disks disks, 
                         double coeffEarnMoneyPerMetr, double money);
        void IncreaseMileage(Car car);
        double RiseMoney(Car car, double distance, double money);
    }
}
