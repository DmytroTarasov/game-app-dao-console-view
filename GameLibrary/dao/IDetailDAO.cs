using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.dao
{
    interface IDetailDAO : IAbstractDAO<Detail>
    {
        bool CheckDetail(Detail detail, double money);
        double RepairDetail(Detail detail, double money);
        void DecrStabilityAfterRepair(Detail detail);
    }
}
