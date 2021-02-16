using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Disks : IBase, IDetail
    {
        public int Diameter { get; set; }
        public double StabilityInOperation { get; set; }
        public double PurchaseCost { get; set; }
        public double RepairCost { get; set; }
        public Guid Id { get; set; }
        public Disks(int diameter, double stabilityInOperation, double purchaseCost, double repairCost)
        {
            GenerateId();
            Diameter = diameter;
            StabilityInOperation = stabilityInOperation;
            PurchaseCost = purchaseCost;
            RepairCost = repairCost;
        }
        public void GenerateId() // под вопросом
        {
            Id = Guid.NewGuid();
        }
    }
}
