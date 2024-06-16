using _0_Freamwork.Domain;
using CarManagment.Application.Contracts.Car;

namespace CarManagment.Domain.CarAgg
{
    public interface ICarRepository : IRepository<long, Car>
    {
        Car Get(long id);
        EditCar GetDetails(long id);
        List<CarViewModel> GetCars();
        List<CarViewModel> Serach(CarSearchModel searchModel);
        List<CarViewModel> GetCarsByGroupId(long groupId);
    }
}
