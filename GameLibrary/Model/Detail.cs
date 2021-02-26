using System;

namespace GameLibrary.Model
{
    public class Detail : IBase
    {
        private Guid _id;
        public double Stability { get; set; }
        public double PurchaseCost { get; set; }
        public double RepairCost { get; set; }
        public bool IsBroken { get; set; }
        public bool CanBeRepaired { get; set; }
        public double CoeffDecrStability { get; set; }
        public Guid Id { get { if (_id == Guid.Empty) { _id = Guid.NewGuid(); return _id; } else { return _id; } } }
        public Car Car { get; set; }
        public Detail(double stability, double purchaseCost, double repairCost, double coeffDecrStability)
        {
            Stability = stability;
            PurchaseCost = purchaseCost;
            RepairCost = repairCost;
            CoeffDecrStability = coeffDecrStability;
        }
    }
}
