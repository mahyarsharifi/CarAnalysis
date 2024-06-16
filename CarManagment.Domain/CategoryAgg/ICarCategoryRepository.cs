using _0_Freamwork.Domain;
using CarManagment.Application.Contracts.CarCateory;

namespace CarManagment.Domain.CategoryAgg
{
    public interface ICarCategoryRepository : IRepository<long, CarCategory>
    {
        CarCategory Get(long id);
        List<CarCategoryViewModel> GetCarCategories();
        EditCarCategory GetDetails(long id);
    }
}
