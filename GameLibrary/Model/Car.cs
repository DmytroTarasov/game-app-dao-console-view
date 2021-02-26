using System;

namespace GameLibrary
{
    public class Car : IBase
    {
        private Guid _id;
        public Guid Id { get { if (_id == Guid.Empty) { _id = Guid.NewGuid(); return _id; }  else { return _id; } } }
        public double Mileage { get; set; }
        public Engine Engine { get; set; }
        public Accumulator Accumulator { get; set; }
        public Disks Disks { get; set; }
        public double CoeffMoneyPerKilometer { get; set; }
        public Car(Engine engine, Accumulator accumulator, Disks disks, double coeffMoneyPerKilometer)
        {
            Mileage = 0;
            CoeffMoneyPerKilometer = coeffMoneyPerKilometer;
            Engine = engine;
            Accumulator = accumulator;
            Disks = disks;         
        }

        public override string ToString()
        {
            return "Engine: " + Engine + "\n" + 
                "Accumulator: " + Accumulator + "\n" +
                "Disks: " + Disks + "\n" +
                "CoeffEarnMoneyPerMetr: " + CoeffMoneyPerKilometer;
        }
    }
}
