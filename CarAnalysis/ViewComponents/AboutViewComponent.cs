using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
