using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    interface IDetail
    {
        double StabilityInOperation { get; set; }
        double PurchaseCost { get; set; }
        double RepairCost { get; set; }
        bool IsBroken { get; set; }
        bool CanBeRepaired { get; set; }
    }
}
