using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string FulName { get; set; }
        [Required]
        [StringLength(maximumLength:25)]

        public string UserName{ get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Pasword{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Pasword))]
        public string ConfirmPasword{ get; set; }
        public bool Terms { get; set; }
        
    }
}
