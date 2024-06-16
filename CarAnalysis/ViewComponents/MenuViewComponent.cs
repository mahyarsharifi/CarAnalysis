using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
