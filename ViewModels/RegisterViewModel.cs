using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string GitHubPageLink { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //[Compare(nameof(Password), ErrorMessage = "Паролі не співпаають")]
        //public string ConfirmPassword { get; set; }
    }
}
