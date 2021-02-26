using GameLibrary.Model;

namespace GameLibrary
{
    public class Engine : Detail
    {
        public string Type { get; set; }
        public Engine(string type, double stability, double purchaseCost, double repairCost, double coeffDecrStability) :
            base(stability, purchaseCost, repairCost, coeffDecrStability) 
        {
            Type = type;
            IsBroken = false;
            CanBeRepaired = true;
        }
        public override string ToString()
        {
            return "Type: " + Type + ", Stability: " + Stability + ", PurchaseCost: " + PurchaseCost +
                ", RepairCost: " + RepairCost;
        }
    }
}
