using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Disks : Detail
    {
        public int Diameter { get; set; }
        public Disks(int diameter, double stabilityInOperation, double purchaseCost, double repairCost) :
            base(stabilityInOperation, purchaseCost, repairCost)
        {
            Diameter = diameter;
            IsBroken = false;
            CanBeRepaired = true;
        }
    }
}
