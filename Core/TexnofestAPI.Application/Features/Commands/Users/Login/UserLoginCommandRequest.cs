using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexnofestAPI.Application.Features.Commands.Users.Login
{
    public class UserLoginCommandRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
