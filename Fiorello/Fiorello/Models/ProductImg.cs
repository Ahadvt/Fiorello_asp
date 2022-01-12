using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class ProductImg
    {
        public int Id { get; set; }
        public string Img { get; set; }
     
        public int ProductID { get; set; }

        public Product Product { get; set; }
    }
}
