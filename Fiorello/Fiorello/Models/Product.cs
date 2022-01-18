using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        public bool Instock { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Deminition { get; set; }
        public int Skucode { get; set; }
        public List<ProductCategory> ProductCategorys { get; set; }
        public List<ProductImg> ProductImgs { get; set; }
        public int? DiscauntId { get; set; }
        public Discount Discaunt { get; set; }

        [NotMapped]
        public List<int> CategoryIds { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFile { get; set; }
        [NotMapped]
        public List<int> ImgIds { get; set; }





    }
}
