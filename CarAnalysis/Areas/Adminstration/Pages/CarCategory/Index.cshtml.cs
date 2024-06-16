using CarManagment.Application.Contracts.CarCateory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.CarCategory
{
    public class IndexModel : PageModel
    {
        public List<CarCategoryViewModel> CarCategories;

        private readonly ICarCategoryApplication _carCategoryApplication;

        public IndexModel(ICarCategoryApplication carCategoryApplication)
        {
            _carCategoryApplication = carCategoryApplication;
        }

        public void OnGet()
        {
            CarCategories = _carCategoryApplication.GetCarCategories().ToList();
        }
    }
}
