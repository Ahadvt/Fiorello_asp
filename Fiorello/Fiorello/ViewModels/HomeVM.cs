using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public Settings settings { get; set; }
        public List<ExpertPosition> expertsp { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Carusel> carusels { get; set; }
        public List<ProductCategory> productCategories { get; set; }
        public List<Category> categories { get; set; }
        public List<Discount> discounts { get; set; }
        public List<Product> products { get; set; }
        

    }
}
