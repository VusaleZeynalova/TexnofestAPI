using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexnofestAPI.Domain.Entities.Common;

namespace TexnofestAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPoint { get; set; }
        public List<ProductUser> ProductUsers { get; set; }

    }
}
