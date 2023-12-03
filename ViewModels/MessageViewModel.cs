using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        public bool isRead { get; set; }
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public int SolutionId { get; set; }
        public string MesText { get; set; }
        public int MesType { get; set; }

        public string PostDate { get; set; }
    }
}
