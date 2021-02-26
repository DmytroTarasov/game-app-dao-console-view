using GameLibrary.Model;

namespace GameLibrary
{
    public class Disks : Detail
    {
        public int Diameter { get; set; }
        public Disks(int diameter, double stability, double purchaseCost, double repairCost, double coeffDecrStability) :
            base(stability, purchaseCost, repairCost, coeffDecrStability)
        {
            Diameter = diameter;
            IsBroken = false;
            CanBeRepaired = true;
        }
        public override string ToString()
        {
            return "Diameter: " + Diameter + ", Stability: " + Stability + ", PurchaseCost: " + PurchaseCost +
                ", RepairCost: " + RepairCost;
        }
    }
}
