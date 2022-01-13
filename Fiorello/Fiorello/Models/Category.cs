using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="bos ola bilmez")]
        [StringLength(maximumLength: 50 ,ErrorMessage ="max uzunluq 50 dir")]
        public string Name { get; set; }
       
        public List<ProductCategory> ProductCategorys { get; set; }
    }
}
