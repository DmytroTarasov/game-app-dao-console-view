using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Engine : Detail
    {
        public string Type { get; set; }
        public Engine(string type, double stabilityInOperation, double purchaseCost, double repairCost) :
            base(stabilityInOperation, purchaseCost, repairCost) 
        {
            Type = type;
            IsBroken = false;
            CanBeRepaired = true;
        }
    }
}
