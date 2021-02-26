using GameLibrary.Model;

namespace GameLibrary.dao
{
    public interface IDetailDAO : IAbstractDAO<Detail>
    {
        double CheckDetail(Detail detail, double money);
        double RepairDetail(Detail detail, double money);
        bool DecrStabilityAfterRepair(Detail detail);
        double ReplaceDetail(Car car, Detail detail, Detail newdetail, double money);
    }
}
