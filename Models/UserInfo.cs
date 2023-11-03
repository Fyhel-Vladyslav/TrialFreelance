using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrialFreelance.Models
{
    public class UserInfo
    {
        [Key]
        public long UserId { get; set; }
        public string GitHubPageLink { get; set; }
        public int FinishedOrders { get; set; }
    }
}
