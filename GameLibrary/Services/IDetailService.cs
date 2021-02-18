using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Services
{
    interface IDetailService
    {
       bool CheckDetail(Detail detail, double money);
       double RepairDetail(Detail detail, double money);
    }
}
