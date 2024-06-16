using CarManagment.Application.Contracts.Car;
using CarManagment.Application.Contracts.CarCateory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarAnalysis.Areas.Adminstration.Pages.Car
{
    public class IndexModel : PageModel
    {
        public CarSearchModel SearchModel;
        public List<CarViewModel> Cars;
        public SelectList CarCategories;
        private readonly ICarApplication _carApplication;
        private readonly ICarCategoryApplication _carCategoryApplication;
        public IndexModel(ICarApplication carApplication, ICarCategoryApplication carCategoryApplication)
        {
            _carApplication = carApplication;
            _carCategoryApplication = carCategoryApplication;
        }
        public void OnGet(CarSearchModel searchModel)
        {
            CarCategories = new SelectList(_carCategoryApplication.GetCarCategories(), "Id", "Name");
            Cars = _carApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateCar
            {
                Categories = _carCategoryApplication.GetCarCategories()
            };
            return Partial("Create", command);
        }

        public JsonResult OnPostCreate(CreateCar command)
        {
            var result = _carApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var car = _carApplication.GetDetails(id);
            car.Categories = _carCategoryApplication.GetCarCategories();
            return Partial("Edit", car);
        }

        public JsonResult OnPostEdit(EditCar command)
        {
            var result = _carApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
