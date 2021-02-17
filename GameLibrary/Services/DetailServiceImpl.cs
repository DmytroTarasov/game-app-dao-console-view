using GameLibrary.daoImpl;
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

        public bool CheckDetail(IDetail detail)
        {
            
        }

        public double RepairDetail(IDetail detail, double money)
        {
            throw new NotImplementedException();
        }

        //public void RepairDetail(List<IDetail> details, double money)
        //{
        //    details.ForEach(detail => money -= detail.)
        //}
        //public void CheckDetail(IDetail detail)
        //{
        //    Random x = new Random();
        //    double r = Convert.ToDouble(x.Next(1));

        //    if (r > detail.StabilityInOperation)
        //    {
        //        detail.IsBroken = true;
        //    }
        //}
    }
}
