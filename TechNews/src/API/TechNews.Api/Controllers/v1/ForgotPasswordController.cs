using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Net.Mail;
using TechNews.Api.Services;
using TechNews.Application.Contracts;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Models.Mail;
using TechNews.Domain.Entities;
using TechNews.Persistence.Models;
using WebMatrix.WebData;

namespace TechNews.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IForgotPassword _forgotPassword;
        private readonly IMediator _mediator;
        private readonly ISendMailService _mailService;

        public ForgotPasswordController(IForgotPassword forgotPassword, IMediator mediator, ISendMailService mailService)
        {
            _forgotPassword = forgotPassword;
            _mediator = mediator;
            _mailService = mailService;
        }


        [HttpPost("ForgotUserPassword",Name = "ForgotUserPassword")]
        public async Task<IActionResult> ForgotUserPassword(ForgotPasswordVM forgotPasswordVM)
        {
            var response = await _forgotPassword.UserExists(forgotPasswordVM.Email);
            
            if (response != null)
            {
                // send mail
                string subject = "Link to reset your Password";
                //string body = $"<div style=\"color:black\">Hello, <br>" +
                //    $"<p>You have requested us to send a link to reset your password for your Tech News                                  account.</p>" +
                //    $"<a style=\"background-color: green;padding: 10px 25px;color:white;border-radius: 20px;\" href=\"https://localhost:7259/Forget/ResetPassword?emailId={forgotPasswordVM.Email}\">Reset Password</a> " +
                //    $"<p> If you didn't initiate this request, you can safely ignore this email.</p><br>Thanks!</div>";

                string body = $"<div style='color:black'>" +
                    $"    <p>You have requested us to send a link to reset your password for your Tech News account.</p>" +
                    $"    <form method='post' action='https://localhost:7259/Forget/ResetPasswordMail'>" +
                    $"        <input type='hidden' name='emailId' value='{forgotPasswordVM.Email}'>" +
                    $"        <button style='background-color: green;padding: 10px 25px;color:white;border-radius: 20px;'>Reset Password</button>" +
                    $"    </form>" +
                    $"    <p> If you didn't initiate this request, you can safely ignore this email.</p>" +
                    $"    <p>Thanks!</p>" +
                    $"</div>";
                
                var result = _mailService.SendMail(forgotPasswordVM.Email,subject,body);
                return Ok(result);
                //return Ok();

            }
           
            return Ok();
        }

        [HttpPost("ResetUserPassword", Name = "ResetUserPassword")]
        public async Task<IActionResult> ResetUserPassword(ResetPassword resetPassword)
        {
            var passwordReset = await _forgotPassword.ResetUserPassword(resetPassword);
            return Ok(passwordReset);
        }

        [HttpPost("ChangePassword", Name = "ChangePassword")]
        public async Task<IActionResult> ResetLoginPassword(ResetLoggedInPassword resetLoggedInPassword)
        {
            var loggedInPasswordReset = await _forgotPassword.ResetLoginPassword(resetLoggedInPassword);
            return Ok(loggedInPasswordReset);
        }

        [HttpPost]
        [Route("OldPasswordDoesNotExists")]
        public async Task<ActionResult> OldPasswordDoesNotExist(OldPasswordExists oldPasswordExists)
        {
            var roles = await _forgotPassword.OldPasswordDoesNotExists(oldPasswordExists);
            return Ok(roles);
        }
    }
}
