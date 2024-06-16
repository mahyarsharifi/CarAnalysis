using _0_Freamwork.Application;

namespace CarManagment.Application.Contracts.Car
{
    public interface ICarApplication
    {
        OperationResult Create(CreateCar command);
        OperationResult Edit(EditCar command);
        EditCar GetDetails(long id);
        List<CarViewModel> GetCars();
        List<CarViewModel> GetCarsByGroupId(long groupId);
        List<CarViewModel> Search(CarSearchModel searchModel);
    }
}
