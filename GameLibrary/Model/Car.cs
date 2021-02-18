using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Car : IBase, ICar
    {
        public Guid Id { get; set; }
        public int Speed { get; set; }
        public double Mileage { get; set; }
        public Engine Engine { get; set; }
        public Accumulator Accumulator { get; set; }
        public Disks Disks { get; set; }
        public double CoeffEarnMoneyPerMetr { get; set; }
        public Car(int speed, Engine engine, Accumulator accumulator, Disks disks, double coefficientEarnMoneyPerMetr)
        {
            Id = Guid.NewGuid();
            Speed = speed;
            Mileage = 0;
            CoeffEarnMoneyPerMetr = coefficientEarnMoneyPerMetr;
            Engine = engine;
            Accumulator = accumulator;
            Disks = disks;
            
        }
    }
}
