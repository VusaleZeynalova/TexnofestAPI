using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexnofestAPI.Application.Abstractions.Services
{
    public interface IMailService
    {
        Task SendMessageAsync(string to,string subject,Guid body);
    }
}
