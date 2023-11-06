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
        private ApplicationDbContext dbCon;
        private readonly IMapper mapper;

        public PreOrderRepository(ApplicationDbContext context, IMapper mapper)             
        {
            dbCon = context;
            this.mapper = mapper;
        }

        public PreOrderViewModel FindById(int id)
        {
            return mapper.Map<PreOrderViewModel>(dbCon.Orders.Find(id)); 
        }

        public IEnumerable<PreOrderViewModel> GetAll()
        {
            return mapper.Map<IEnumerable<PreOrderViewModel>>(dbCon.Orders);
        }

        
    }

}
