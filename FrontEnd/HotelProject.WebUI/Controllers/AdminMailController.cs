using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();


            //kimden
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "caglaaksoy2001@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //kime
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //içerik
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("caglaaksoy2001@gmail.com", "qrtbwjqmkzofkwuz");
            client.Send(mimeMessage);
            client.Disconnect(true);

            //gönderilen mailin gönderilmiş postalara(veritabanında) kaydedilmesi
            //üstteki kodları sendmessage controlleına yapıştırcaz.

            return View();
        }
    }
}
