using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Accumulator : Detail
    {
        public int Capacity { get; set; }
        public Accumulator(int capacity, double stabilityInOperation, double purchaseCost, double repairCost) :
            base(stabilityInOperation, purchaseCost, repairCost)
        {
            GenerateId();
            Capacity = capacity;
            IsBroken = false;
            CanBeRepaired = true; 
        }
    }
}
