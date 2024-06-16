using CarManagment.Application.Contracts.Car;
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
        public void OnGet(CarSearchModel searchModel)
        {
            Cars = _carApplication.Search(searchModel);
        }
    }
}
