using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public int Precenet { get; set; }
        public List<Product> Products { get; set; }

    }
}
