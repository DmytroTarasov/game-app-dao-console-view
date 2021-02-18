using GameLibrary.daoImpl;
using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Services
{
    class DetailServiceImpl : IDetailService
    {
        DAOFactory DaoFactory;

        public DetailServiceImpl(DAOFactory daoFactory)
        {
            DaoFactory = daoFactory;
        }
        public bool CheckDetail(Detail detail, double money)
        {
            return DaoFactory.GetDetailDAO().CheckDetail(detail, money);
        }

        public double RepairDetail(Detail detail, double money)
        {
            return DaoFactory.GetDetailDAO().RepairDetail(detail, money);
        }
    }
}
