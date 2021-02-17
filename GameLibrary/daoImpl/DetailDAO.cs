using GameLibrary.dao;
using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.daoImpl
{
    class DetailDAO : AbstractDAO<Detail>, IDetailDAO
    {
        public DetailDAO(Database database) : base (database.Details, database) { }
        public bool CheckDetail(Detail detail)
        {
            double r = Convert.ToDouble(new Random().Next(1));
            if (r > detail.StabilityInOperation)
            {
                detail.IsBroken = true;
                Update(detail.Id, detail);
                //RepairDetail(engine, money);
            }
            return detail.IsBroken;
        }

        public double RepairDetail(Detail detail, double money)
        {
            if (money >= detail.RepairCost)
            {
                detail.IsBroken = false; // нужна проверка, деталь еще ремонтируется или нет + нужно уменьшать прочность детали
                Update(detail.Id, detail);
                money -= detail.RepairCost;
            }
            return money;
        }
    }
}
