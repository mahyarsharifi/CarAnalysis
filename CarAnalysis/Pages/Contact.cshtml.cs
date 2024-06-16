using CarAnalysis.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net;

namespace CarAnalysis.Pages
{
    public class ContactModel : PageModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ContactUs Command;

        public void OnGet()
        {
        }

        public void OnPost(ContactUs contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var stmpClient = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new NetworkCredential("mahyar.sharifi82@gmail.com", "qnrx prvl cqrx qzaw"),
                        EnableSsl = true,
                        UseDefaultCredentials = false,
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(contact.Email),
                        Subject = "New Contact From CarAnalysis",
                        Body = $"Name : {contact.Name} - Message = {contact.Message}",
                        IsBodyHtml = true
                    };

                    mailMessage.To.Add("mahyar.sharifi82@gmail.com");
                    stmpClient.Send(mailMessage);
                    Message = "پیغام با موفقیت ارسال شد";
                    IsSuccess = true; 
                }
                catch (SmtpException smtpEx)
                {
                    Message = $"خطا در ارسال ایمیل: {smtpEx.Message}";
                    IsSuccess = false; 
                }
                catch (Exception ex)
                {
                    Message = $"خطایی رخ داده است: {ex.Message}";
                    IsSuccess = false; 
                }
            }
            else
            {
                Message = "اطلاعات ورودی نامعتبر است";
                IsSuccess = false;
            }
        }
    }
}
