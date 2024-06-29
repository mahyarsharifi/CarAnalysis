using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class _404Model : PageModel
    {
        public string ErrorMessage { get; set; }

        [Route("/404/{code}")]
        public IActionResult OnGet(int code)
        {
            if (code == 404)
            {
                ErrorMessage = "404";
                return Page();
            }
            else
            {
                return null;
            }
        }
    }
}
