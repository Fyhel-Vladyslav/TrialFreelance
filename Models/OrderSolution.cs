using System;
using System.ComponentModel.DataAnnotations;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Models
{
    public class OrderSolution
    {
        [Key]
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public int OrderId { get; set; }
        public string GitHubLink { get; set; }
        public string Description { get; set; }

    }
}
