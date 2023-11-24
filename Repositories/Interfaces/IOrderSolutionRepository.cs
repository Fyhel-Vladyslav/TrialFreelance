using System.Collections.Generic;
using TrialFreelance.Entities;
using TrialFreelance.Models;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Repositories.Interfaces
{
    public interface IOrderSolutionRepository : IGenericRepository<OrderSolution>
    {
        public IEnumerable<OrderSolutionViewModel> GetSolutionsByOrderId(int id);
        public IEnumerable<OrderSolutionViewModel> GetSolutionsByUserId(int id);
        public IEnumerable<OrderSolutionViewModel> GetAllSolutions();
    }
}
