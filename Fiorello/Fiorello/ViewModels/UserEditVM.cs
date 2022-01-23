using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class UserEditVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string CurrentPaswor { get; set; }
        [DataType(DataType.Password)]
        public string NewPasword { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(NewPasword))]
        public string ConfirmPasword { get; set; }
      
    }
}
