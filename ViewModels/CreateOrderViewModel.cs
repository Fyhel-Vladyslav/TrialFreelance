using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrialFreelance.ViewModels
{
    public class CreateOrderViewModel
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int OwnerId { get; set; }
        public string ExampleLink { get; set; }
        public string GitHubLink { get; set; }
        public string DbLink { get; set; }
        public string SecondaryTasks { get; set; }
        public string MainTask { get; set; }
        public string Description { get; set; }
    }
}
