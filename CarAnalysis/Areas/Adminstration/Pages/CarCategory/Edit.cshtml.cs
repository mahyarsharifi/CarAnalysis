using CarManagment.Application.Contracts.CarCateory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Areas.Adminstration.Pages.CarCategory
{
    public class EditModel : PageModel
    {
        public EditCarCategory Command;
        private readonly ICarCategoryApplication _carCategoryApplication;

        public EditModel(ICarCategoryApplication carCategoryApplication)
        {
            _carCategoryApplication = carCategoryApplication;
        }

        public void OnGet(long id)
        {
            Command = _carCategoryApplication.GetDetails(id);
        }
        public JsonResult OnPost(EditCarCategory command)
        {
            var result = _carCategoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}