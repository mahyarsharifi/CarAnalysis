using _0_Freamwork.Application;

namespace CarManagment.Application.Contracts.CarCateory
{
    public interface ICarCategoryApplication
    {
        OperationResult Create(CreateCarCategory command);
        OperationResult Edit(EditCarCategory command);
        EditCarCategory GetDetails(long id);
        List<CarCategoryViewModel> GetCarCategories();

    }
}
