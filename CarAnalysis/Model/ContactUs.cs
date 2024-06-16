using System.ComponentModel.DataAnnotations;

namespace CarAnalysis.Model
{
    public class ContactUs
    {
        [Required(ErrorMessage = "نام خود را وارد کنید")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ایمیل خود را وارد کنید")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پیام خود را وارد کنید")]
        public string Message { get; set; }
    }
}
