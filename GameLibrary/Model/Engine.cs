using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Engine : IBase, IDetail
    {
        public string Type { get; set; }
        public double StabilityInOperation { get; set; }
        public double PurchaseCost { get; set; }
        public double RepairCost { get; set; }
        public Guid Id { get; set; }

        public Engine(string Type, double StabilityInOperation, double PurchaseCost, double RepairCost)
        {
            //GenerateId();
            Id = Guid.NewGuid();
            this.Type = Type;
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
