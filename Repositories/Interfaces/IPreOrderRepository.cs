using AutoMapper;
using System.Collections.Generic;
using TrialFreelance.Entities;
using TrialFreelance.Models;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Repositories.Interfaces
{
    public interface IPreOrderRepository
    {
        PreOrderViewModel FindById(int id);
        IEnumerable<PreOrderViewModel> GetAll();
        IEnumerable<PreOrderViewModel> FindOrdersByUserId(int id);
    }
}
