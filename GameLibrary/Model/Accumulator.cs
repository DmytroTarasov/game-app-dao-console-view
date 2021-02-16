using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Accumulator : IBase, IDetail
    {
        public int Capacity { get; set; }
        public double StabilityInOperation { get; set; }
        public double PurchaseCost { get; set; }
        public double RepairCost { get; set; }
        public Guid Id { get; set; }

        public Accumulator(int Capacity, double StabilityInOperation, double PurchaseCost, double RepairCost)
        {
            GenerateId();
            this.Capacity = Capacity;
            this.StabilityInOperation = StabilityInOperation;
            this.PurchaseCost = PurchaseCost;
            this.RepairCost = RepairCost;
        }

        public void GenerateId() // под вопросом
        {
            Id = Guid.NewGuid();
        }
    }
}
