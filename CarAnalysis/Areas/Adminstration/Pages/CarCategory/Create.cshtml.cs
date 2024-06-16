using CarManagment.Application.Contracts.CarCateory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.CarCategory
{
    public class CreateModel : PageModel
    {
        public CreateCarCategory Command;

        private readonly ICarCategoryApplication _carCategoryApplication;

        public CreateModel(ICarCategoryApplication carCategoryApplication)
        {
            _carCategoryApplication = carCategoryApplication;
        }

        public void OnGet()
        {
        }
        public JsonResult OnPost(CreateCarCategory command)
        {
            var result = _carCategoryApplication.Create(command);
            return new JsonResult(result);
        }
    }
}