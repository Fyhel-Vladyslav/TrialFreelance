using TrialFreelance.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class EditUserViewModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string GitHubPageLink { get; set; }
        public int FinishedOrders { get; set; }
        public List<AllRoleViewModel> AllRoles { get; set; }
    }
}
