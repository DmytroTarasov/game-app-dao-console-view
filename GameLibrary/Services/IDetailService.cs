using GameLibrary.Model;
using System;
using System.Collections.Generic;

namespace GameLibrary.Services
{
    interface IDetailService
    {
        List<Detail> GetAllDetails();
        List<Detail> GetAllCarDetails(Car car);
        Detail GetDetailById(Guid id);
        List<Detail> FindDetailsByType(Type detailType);
        double CheckDetail(Detail detail, double money);
        double RepairDetail(Detail detail, double money);
        void DecrStabilityAfterRepair(Detail detail);
        double ReplaceDetail(Car car, Detail detail, Detail newdetail, double money);
    }
}
