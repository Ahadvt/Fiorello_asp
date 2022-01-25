using Fiorello.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class CreateAdminVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Pasword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Pasword))]
        public string ConfirmPasword { get; set; }
        public bool IsAdmin { get; set; }
        public string Role { get; set; }

    }
}
