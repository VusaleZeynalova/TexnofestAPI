using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;
using TexnofestAPI.Domain.Entities.Identity;

namespace TexnofestAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public int ProductPoint { get; set; }
        public List<AspNetUser> AppUsers { get; set; }

    }
}
