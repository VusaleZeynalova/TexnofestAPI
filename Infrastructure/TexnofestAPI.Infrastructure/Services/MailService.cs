using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Application.Abstractions.Services;

namespace TexnofestAPI.Infrastructure.Services
{
    public class MailService : IMailService
    {
        readonly IConfiguration _configuration;
        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public async Task SendMessageAsync(string to, string subject,Guid body)
        {
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.Subject = subject;
            message.Body = Convert.ToString(body);
            message.From = new(_configuration["Mail:Username"], "TexnoFest", System.Text.Encoding.UTF8);
            SmtpClient smtpClient = new();
            smtpClient.Credentials = new NetworkCredential(_configuration["Mail:Username"], _configuration["Mail:Password"]);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Host="smtp.gmail.com";
            smtpClient.EnableSsl = true;
            await smtpClient.SendMailAsync(message);
        }
    }
}
