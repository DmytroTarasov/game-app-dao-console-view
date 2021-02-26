using GameLibrary.dao;
using GameLibrary.Model;
using System;
using System.Reflection;

namespace GameLibrary.daoImpl
{
    public class DetailDAO : AbstractDAO<Detail>, IDetailDAO
    {
        public DetailDAO(Database database) : base (database.Details, database) { }
        public double CheckDetail(Detail detail, double money)
        {
            double r = new Random().NextDouble();
            if (r > detail.Stability)
            {
                detail.IsBroken = true;
                money = RepairDetail(detail, money);
            }
            return money;
        }

        public double RepairDetail(Detail detail, double money)
        {
            if (money >= detail.RepairCost && DecrStabilityAfterRepair(detail)) 
            {
                detail.IsBroken = false;
                money -= detail.RepairCost;
            };
            return money;
        }
        public bool DecrStabilityAfterRepair(Detail detail)
        {
            if (detail.Stability - detail.CoeffDecrStability > 0.1) // ремонт разрешен
            {
                detail.Stability = Math.Round(detail.Stability - detail.CoeffDecrStability, 1);
                return true;
            }
            else
            {
                detail.CanBeRepaired = false;
                return false;
            }
        }

        public double ReplaceDetail(Car car, Detail detail, Detail newdetail, double money)
        {
            if (money >= newdetail.PurchaseCost)
            {
                foreach (PropertyInfo prop in car.GetType().GetProperties())
                {
                    if (newdetail.GetType().ToString().Contains(prop.Name))
                    {
                        prop.SetValue(car, newdetail);
                        Database.Details.Remove(detail.Id);
                    }
                }
                money -= newdetail.PurchaseCost;
                return money;
            }
            return -1;   
        }
    }
}
