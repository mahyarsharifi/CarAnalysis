using _01_CarAnalysisQuery.Contracts.Car;
using CarManagment.Application.Contracts.CarPicture;
using CommentManagement.Application.Contracts.Comment;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class CarDetailsModel : PageModel
    {
        public CarQueryModel Car;
        public List<CommentViewModel> Comments;
        public List<CarPictureViewModel> CarPictures;

        private readonly ICarQuery _carQuery;
        private readonly ICommentApplication _commentApplication;
        private readonly ICarPictureApplication _carPictureApplication;

        public CarDetailsModel(ICarQuery carQuery, ICommentApplication commentApplication, ICarPictureApplication carPictureApplication)
        {
            _carQuery = carQuery;
            _commentApplication = commentApplication;
            Car = new CarQueryModel();
            _carPictureApplication = carPictureApplication;
        }

        public void OnGet(int id)
        {
            Car = _carQuery.GetCar(id);
            Comments = _commentApplication.GetCarCommentsByParentId(id);
            CarPictures = _carPictureApplication.GetCarPictures(id);
        }
        public IActionResult OnPost(AddComment command, int id)
        {
            command.Type = CommentType.Car;
            command.ParentId = id;
            var result = _commentApplication.Add(command);
            return RedirectToPage("./CarDetails", new { Id = id });
        }
    }
}
