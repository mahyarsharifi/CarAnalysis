using _01_CarAnalysisQuery.Contracts.Car;
using CarManagment.Application.Contracts.CarCateory;
using CarManagment.Domain.CategoryAgg;
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

        private readonly ICarQuery _carQuery;
        private readonly ICommentApplication _commentApplication;


        public CarDetailsModel(ICarQuery carQuery, ICommentApplication commentApplication)
        {
            _carQuery = carQuery;
            _commentApplication = commentApplication;
            Car = new CarQueryModel();
        }

        public void OnGet(int id)
        {
            Car = _carQuery.GetCar(id);
            Comments = _commentApplication.GetCarCommentsByParentId(id);

        }
        public IActionResult OnPost(AddComment command, int id)
        {
            command.Type = CommentType.Car;
            command.ParentId = id;
            var result = _commentApplication.Add(command);
            return RedirectToPage("./Car", new { Id = id });
        }
    }
}
