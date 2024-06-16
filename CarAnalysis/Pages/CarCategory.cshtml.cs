using CarManagment.Application.Contracts.CarCateory;
using CarManagment.Domain.CategoryAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class CarCategoryModel : PageModel
    {
        public List<CarCategoryViewModel> CarCategories;
        private readonly ICarCategoryRepository _carCategoryRepository;

        public CarCategoryModel(ICarCategoryRepository carCategoryRepository)
        {
            _carCategoryRepository = carCategoryRepository;
        }

        public void OnGet()
        {
            CarCategories = _carCategoryRepository.GetCarCategories();
        }
    }
}
