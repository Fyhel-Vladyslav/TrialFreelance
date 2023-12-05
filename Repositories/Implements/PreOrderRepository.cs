using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TrialFreelance.Data;
using TrialFreelance.Models;
using TrialFreelance.Repositories.Interfaces;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Repositories.Implements
{
    public class PreOrderRepository : IPreOrderRepository
    {
        private readonly IMapper mapper;
        private readonly IOrderRepository iOrderRepository;

        public PreOrderRepository(IMapper mapper, IOrderRepository iOrderRepository)             
        {
            this.mapper = mapper;
            this.iOrderRepository = iOrderRepository;
        }

        public PreOrderViewModel FindById(int id)
        {
            return mapper.Map<PreOrderViewModel>(iOrderRepository.FindById(id)); 
        }
        public List<PreOrderViewModel> SearchByName(string request)
        {
            return mapper.Map<List<PreOrderViewModel>>(iOrderRepository.SearchByName(request)); 
        }
        public IEnumerable<PreOrderViewModel> GetAll()
        {
            return mapper.Map<IEnumerable<PreOrderViewModel>>(iOrderRepository.GetAll());
        }

        public IEnumerable<PreOrderViewModel> FindOrdersByUserId(int id)
        {
            return mapper.Map < IEnumerable < PreOrderViewModel >> (iOrderRepository.GetOrdersByUserId(id));
        }
    }

}
