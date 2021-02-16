using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Car : IBase, ICar
    {
        public Guid Id { get; set; }
        public Engine Engine { get; set; }
        public Accumulator Accumulator { get; set; }
        public Disks Disks { get; set; }
        public void GenerateId() // под вопросом
        {
            Id = Guid.NewGuid();
        }
        public Car(Engine engine, Accumulator accumulator, Disks disks)
        {
            GenerateId();
            Engine = engine;
            Accumulator = accumulator;
            Disks = disks;
        }
    }
}
