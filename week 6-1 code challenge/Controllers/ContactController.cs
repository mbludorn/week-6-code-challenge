using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text;
namespace week_6_1_code_challenge.Controllers
{
    public class ContactController : Controller

    {
        Models.spMorganEntities4 db = new Models.spMorganEntities4();
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Contactajax());
        }


        [HttpPost]
        public ActionResult Index(Models.Contactajax contact)
        {
            //sending an email
            //Step 1: add using system.Net.Mail;
            //Step2: Create a new message
            MailMessage message = new MailMessage("TheRobots@place.com", "morganbludorn@gmail.com");
            //Step3: Set the Subject
            message.Subject = "Contact Request from " + contact.Name;
            //Step 4: Construct the Body with a string builder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("Name: " + contact.Name);
            sb.AppendLine("Email: " + contact.Email);
            sb.AppendLine("Message: " + contact.Message);
            sb.AppendLine("I Love You,");
            sb.AppendLine("The Robot");
            //Step 5: add the body to the message
            message.Body = sb.ToString();
            //Step 6: Declare the SMTP Cliet aka the mail server
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //Step 7: Send the message
            smtpClient.Send(message);
            //Done.

            //Kick the user to the Thank You Page
            return PartialView("ThankYou");






        }

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
