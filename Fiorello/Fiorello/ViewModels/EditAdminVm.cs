using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class EditAdminVm
    {
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string CurrenPasword { get; set; }
        [DataType(DataType.Password)]

        public string Pasword { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Pasword))]
        public string ConfirmPasword { get; set; }
        public string Role { get; set; }
    }
}
