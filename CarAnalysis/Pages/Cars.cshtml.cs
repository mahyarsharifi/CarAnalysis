using CarManagment.Application.Contracts.Car;
using CarManagment.Application.Contracts.CarCateory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class CarsModel : PageModel
    {
        public CarCategoryViewModel CarCategory;
        public List<CarViewModel> Cars;
        private readonly ICarApplication _carApplication;
        private readonly ICarCategoryApplication _carCategoryApplication;

        public CarsModel(ICarApplication carApplication, ICarCategoryApplication carCategoryApplication)
        {
            _carApplication = carApplication;
            _carCategoryApplication = carCategoryApplication;
        }

        public void OnGet(long groupId)
        {
            Cars = _carApplication.GetCarsByGroupId(groupId);
            CarCategory = _carCategoryApplication.GetCarCategory(groupId);
        }
    }
}
