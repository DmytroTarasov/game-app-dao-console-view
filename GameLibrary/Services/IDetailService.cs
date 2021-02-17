using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Services
{
    interface IDetailService
    {
       bool CheckDetail(IDetail detail);
       double RepairDetail(IDetail detail, double money);
    }
}
