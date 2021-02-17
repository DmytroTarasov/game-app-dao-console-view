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
        public void GenerateId() // под вопросом
        {
            Id = Guid.NewGuid();
        }
        public Car(int speed, Engine engine, Accumulator accumulator, Disks disks)
        {
            GenerateId();
            Speed = speed;
            Mileage = 0;
            Engine = engine;
            Accumulator = accumulator;
            Disks = disks;
            
        }
    }
}
