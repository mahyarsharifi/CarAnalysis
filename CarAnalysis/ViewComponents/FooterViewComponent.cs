using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
