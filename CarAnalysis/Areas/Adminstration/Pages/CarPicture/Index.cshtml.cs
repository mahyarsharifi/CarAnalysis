using CarManagment.Application.Contracts.Car;
using CarManagment.Application.Contracts.CarPicture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarAnalysis.Areas.Adminstration.Pages.CarPicture
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public CarPictureSearchModel SearchModel;
        public List<CarPictureViewModel> CarPictures;
        public SelectList Cars;

        private readonly ICarApplication _carApplication;
        private readonly ICarPictureApplication _carPictureApplication;
        public IndexModel(ICarApplication carApplication, ICarPictureApplication carPictureApplication)
        {
            _carApplication = carApplication;
            _carPictureApplication = carPictureApplication;
        }
        public void OnGet(CarPictureSearchModel searchModel)
        {
            Cars = new SelectList(_carApplication.GetCars(), "Id", "CarName");
            CarPictures = _carPictureApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var command = new CreateCarPicture
            {
                Cars = _carApplication.GetCars()
            };
            return Partial("Create", command);
        }

        public JsonResult OnPostCreate(CreateCarPicture command)
        {
            var result = _carPictureApplication.Create(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long id)
        {
            var carPicture = _carPictureApplication.GetDetails(id);
            carPicture.Cars = _carApplication.GetCars();
            return Partial("Edit", carPicture);
        }

        public JsonResult OnPostEdit(EditCarPicture command)
        {
            var result = _carPictureApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetRemove(long id)
        {
            var result = _carPictureApplication.Removed(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Message = result.Message;
                return RedirectToPage("./Index");
            }
        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _carPictureApplication.Restore(id);
            if (result.IsSuccedded)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Message = result.Message;
                return RedirectToPage("./Index");
            }
        }
    }
}
