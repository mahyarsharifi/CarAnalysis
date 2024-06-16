using CarManagment.Application.Contracts.Car;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class IndexModel : PageModel
    {
        public List<CarViewModel> Cars;
        public CarSearchModel SearchModel;
        private readonly ICarApplication _carApplication;
        public IndexModel(ICarApplication carApplication)
        {
            _carApplication = carApplication;
        }
        public void OnGet(CarSearchModel searchModel)
        {
            Cars = _carApplication.Search(searchModel);
        }
    }
}