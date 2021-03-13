using GameLibrary.daoImpl;
using GameLibrary.Model;
using GameLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.Interface
{
    public class ConsoleView
    {
        DAOFactory DaoFactory;
        CarServiceImpl CarService;
        DetailServiceImpl DetailService;
        public ConsoleView(DAOFactory daoFactory)
        {
            DaoFactory = daoFactory;
            CarService = new CarServiceImpl(DaoFactory);
            DetailService = new DetailServiceImpl(DaoFactory);
        }

        public void Begin()
        {
            PrintMainMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
            }
        }
        private void PrintMainMenu()
        {
            Console.WriteLine("1 - Start game");
            Console.WriteLine("2 - Exit");
        }
        private Detail SelectDetail(List<Detail> details)
        {
            int counter = 1;
            details.ForEach(detail => Console.WriteLine($"{counter++} " + detail.ToString()));
            string input = Console.ReadLine();
            Detail d = details.ElementAt(Convert.ToInt32(input) - 1);
            return d;
        }
        private List<Detail> FindDetailsByType(Type detailType)
        {
            Console.WriteLine($"Select {detailType.Name}");
            return DetailService.FindDetailsByType(detailType);
        }
        private (double, Car) CreateCar(Engine engine, Accumulator accumulator, Disks disks, double coeffEarnMoneyPerMetr, double coins)
        {
            Console.WriteLine("Now we will create a car for you");
            return CarService.CreateCar(engine, accumulator, disks, coeffEarnMoneyPerMetr, coins);
        }
        private void StartGame()
        {
            double coeff;
            double coins = 50;
            Car car;
            Console.WriteLine("Before starting the game, you need to choose the details of which your car will consist");
            Console.WriteLine($"You have {coins} coins");

            Engine e = (Engine)SelectDetail(FindDetailsByType(typeof(Engine)));
            Accumulator a = (Accumulator)SelectDetail(FindDetailsByType(typeof(Accumulator)));
            Disks d = (Disks)SelectDetail(FindDetailsByType(typeof(Disks)));

            do
            {
                Console.WriteLine("Input a coefficient of earning money per one kilometer (between 0 and 0.5)");
                coeff = Convert.ToDouble(Console.ReadLine());
            }
            while (coeff <= 0 || coeff > 0.5);     

            (coins, car) = CreateCar(e, a, d, coeff, coins);

            if (coins >= 0)
            {
                Console.WriteLine("Car successfully created");
                Console.WriteLine(car.ToString());
                Console.WriteLine($"You have {coins} coins");
            }
            else
            {
                Console.WriteLine("You don`t have enough money to purchase all details. Game over");
                Console.WriteLine("Do you want to try one more time to start game? Type Y(yes) or N(no)");
                Begin();
            }
            while (Move(car, coins))
            {
                Move(car, coins);
            }
        }
        private bool Move(Car car, double coins)
        {
            Console.WriteLine("Car started moving");
            double initialCarMileage = car.Mileage;
            CarService.IncreaseMileage(car);
            double carMileageAfterMove = car.Mileage;
            Console.WriteLine($"Car drived {car.Mileage} kilometers");
            coins = CarService.RiseMoney(car, carMileageAfterMove - initialCarMileage, coins);
            Console.WriteLine($"You have {coins} coins");
            Console.WriteLine("Checking car details...");
            DetailService.GetAllCarDetails(car).ForEach(detail => coins = DetailService.CheckDetail(detail, coins));
            Console.WriteLine($"You have {coins} coins");
            Console.WriteLine("Checking whether some detail need a replacement");

            coins = CheckDetailForReplace(car, coins);

            Console.WriteLine(car.ToString());

            if (coins >= 0 && Console.ReadKey().Key == ConsoleKey.Enter)
            {
                return true;
            }
            return false;
        }
        private double ReplaceDetail(Car car, Detail detail, Detail newdetail, double coins)
        {
            return DetailService.ReplaceDetail(car, detail, newdetail, coins);
        }
        private double CheckDetailForReplace(Car car, double coins)
        {
            foreach (Detail d in DetailService.GetAllCarDetails(car))
            {
                if (!d.CanBeRepaired)
                {
                    Console.WriteLine(d.GetType().Name + " has/have a too low stability so this detail need to be replaced");
                    Detail detail = SelectDetail(FindDetailsByType(d.GetType()).Where(det => det.Id != d.Id).ToList());
                    coins = ReplaceDetail(car, d, detail, coins);
                    if (coins >= 0)
                    {
                        Console.WriteLine($"You have {coins} coins");
                        Console.WriteLine($"{d.GetType().Name} was/were successfully replaced");                       
                    }
                    else
                    {
                        Console.WriteLine($"{d.GetType().Name} need a replacement but u don`t have enough coins. Game over");
                        Console.WriteLine("Summary car drived " + car.Mileage + " kilometers");
                        Begin();
                    }
                }
                else
                {
                    Console.WriteLine($"{d.GetType().Name} is suitable for use");
                }
            }
            Console.WriteLine("Press Enter to continue driving");
            return coins;
        }
    }
}
