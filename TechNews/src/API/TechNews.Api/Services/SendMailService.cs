using MimeKit;
using MimeKit.Text;
using System.Net.Mail;
using TechNews.Application.Contracts;

namespace TechNews.Api.Services
{
    public class SendMailService: ISendMailService
    {
        public bool SendMail(string email, string subject, string body)
        {
            //string token = WebSecurity.GeneratePasswordResetToken(email);
            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new System.Net.Mail.MailAddress("aniketmaurya1998@gmail.com");
            //mail.Subject = "Link to reset your Password";
            mail.Subject = subject;
            mail.IsBodyHtml = true;

            //mail.Body = $"<a href = 'https://localhost:5000/api/v1/ForgotPassword/ForgotUserPassword/{email}'";
            mail.Body = body;
            //var lnkHref = $"<a href = 'https://localhost:7259/Forget/ResetPassword?emailId={email}'> Reset Password</a>";
            //mail.Body = new TextPart(TextFormat.Html) { Text = "<b>Please find the password Reset Link. </b><br/>" + lnkHref };
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("aniketmaurya1998@gmail.com", "dcdmjdadlguihcwc");
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;
        }
    }
}
