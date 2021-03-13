using GameLibrary.dao;
using GameLibrary.daoImpl;
using GameLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.Services
{
    public class DetailServiceImpl : IDetailService
    {
        IDAOFactory DaoFactory;

        public DetailServiceImpl(IDAOFactory daoFactory)
        {
            DaoFactory = daoFactory;
        }
        public double CheckDetail(Detail detail, double money)
        {
            return DaoFactory.GetDetailDao().CheckDetail(detail, money);
        }
        public double RepairDetail(Detail detail, double money)
        {
            return DaoFactory.GetDetailDao().RepairDetail(detail, money);
        }
        public void DecrStabilityAfterRepair(Detail detail)
        {
            DaoFactory.GetDetailDao().DecrStabilityAfterRepair(detail);
        }
        public double ReplaceDetail(Car car, Detail detail, Detail newdetail, double money)
        {
            return DaoFactory.GetDetailDao().ReplaceDetail(car, detail, newdetail, money);
        }
        public List<Detail> GetAllDetails()
        {
            return DaoFactory.GetDetailDao().FindAll();
        }
        public Detail GetDetailById(Guid id)
        {
            return DaoFactory.GetDetailDao().Get(id);
        }
        public List<Detail> GetAllCarDetails(Car car)
        {
            return DaoFactory.GetDetailDao().FindAll().Where(detail => detail.Car == car).ToList();
        }
        public List<Detail> FindDetailsByType(Type detailType)
        {
            List<Detail> details = GetAllDetails();
            return details.Where(detail => detail.GetType() == detailType).ToList();
        }
    }
}
