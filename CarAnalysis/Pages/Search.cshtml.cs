using CarManagment.Application.Contracts.Car;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class SearchModel : PageModel
    {
        public List<CarViewModel> Cars;
        public CarSearchModel SearchCarModel;
        private readonly ICarApplication _carApplication;
        public SearchModel(ICarApplication carApplication)
        {
            _carApplication = carApplication;
        }
        public IActionResult OnGet(CarSearchModel searchModel)
        {
            if (IsSearchModelEmpty(searchModel))
            {
                Cars = new List<CarViewModel>();
            }
            else
            {
                Cars = _carApplication.Search(searchModel);
            }
            return Page();
        }

        private bool IsSearchModelEmpty(CarSearchModel searchModel)
        {
            return string.IsNullOrEmpty(searchModel.CarName);
        }
    }
}
