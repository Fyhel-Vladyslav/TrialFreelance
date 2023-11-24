using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class OrderSolutionViewModel
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int OrderId { get; set; }
        public string CreatorUserName { get; set; }
        public string GitHubLink { get; set; }
        public string Description { get; set; }
    }
}
