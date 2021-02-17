using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Model
{
    class Detail : IDetail, IBase
    {
        public double StabilityInOperation { get; set; }
        public double PurchaseCost { get; set; }
        public double RepairCost { get; set; }
        public bool IsBroken { get; set; }
        public bool CanBeRepaired { get; set; }
        public Guid Id { get; set; }
        public Detail(double stabilityInOperation, double purchaseCost, double repairCost)
        {
            Id = Guid.NewGuid();
            StabilityInOperation = stabilityInOperation;
            PurchaseCost = purchaseCost;
            RepairCost = repairCost;
        }

        //public void GenerateId()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
