using System.Collections.Generic;
using TrialFreelance.Entities;
using TrialFreelance.Models;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Repositories.Interfaces
{
    public interface IOrderRepository: IGenericRepository<Order>
    {
        public List<string> GetNames();
        public List<Order> SearchByName(string request);
        public IEnumerable<Order> GetOrdersByUserId(int id);
    }
}
