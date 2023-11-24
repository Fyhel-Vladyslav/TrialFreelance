using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class EditSolutionViewModel
    {
        public int Id { get; set; }
        [Required]
        public int CreatorId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string GitHubLink { get; set; }
        public string Description { get; set; }
    }
}
