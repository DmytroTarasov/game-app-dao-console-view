using GameLibrary.Model;

namespace GameLibrary
{
    public class Accumulator : Detail
    {
        public int Capacity { get; set; }
        public Accumulator(int capacity, double stability, double purchaseCost, double repairCost, double coeffDecrStability) :
            base(stability, purchaseCost, repairCost, coeffDecrStability)
        {
            Capacity = capacity;
            IsBroken = false;
            CanBeRepaired = true; 
        }
        public override string ToString()
        {
            return "Capacity: " + Capacity + ", Stability: " + Stability + ", PurchaseCost: " + PurchaseCost +
                ", RepairCost: " + RepairCost;
        }
    }
}
