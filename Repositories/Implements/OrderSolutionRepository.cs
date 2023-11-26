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
    public class OrderSolutionRepository : IOrderSolutionRepository
    {
        private readonly IMapper mapper;
        private ApplicationDbContext dbCon;
        private DbContextOptions<ApplicationDbContext> options;
        public OrderSolutionRepository(IMapper mapper, ApplicationDbContext context, DbContextOptions<ApplicationDbContext> options)             
        {
            dbCon = context;
            this.mapper = mapper;
            this.options = options;
        }

        public void Add(OrderSolution item)
        {
            dbCon.OrderSolutions.Add(item);
            dbCon.SaveChanges();
        }

        public void Delete(OrderSolution model)
        {
            dbCon.OrderSolutions.Remove(model);
            dbCon.SaveChanges();
        }

        public OrderSolution FindById(int id)
        {
            return dbCon.OrderSolutions.Find(id);
        }

        public IEnumerable<OrderSolution> GetAll()
        {
            return dbCon.OrderSolutions;
        }
        public void Update(OrderSolution order)
        {
           dbCon.Entry(order).State = EntityState.Modified;
            dbCon.SaveChanges();
        }
        public IEnumerable<OrderSolutionViewModel> GetAllSolutions()
        {
            return GetSolutionsByOrderId(-1);
        }
        public IEnumerable<OrderSolutionViewModel> GetSolutionsByOrderId(int id)
        {
            var dbCon2 = new ApplicationDbContext(options);
            List<OrderSolutionViewModel> solutionViewModels;
            if (id != -1)
                solutionViewModels = mapper.Map<IEnumerable<OrderSolutionViewModel>>(dbCon.OrderSolutions).Where(p => p.OrderId == id).ToList();
            else
             solutionViewModels = mapper.Map<IEnumerable<OrderSolutionViewModel>>(dbCon.OrderSolutions).ToList();
            
            for (int i = 0; i < solutionViewModels.Count(); i++)
                solutionViewModels[i].CreatorUserName = dbCon2.Users.Find(solutionViewModels[i].CreatorId).UserName;

            return solutionViewModels;
        }

        public IEnumerable<OrderSolutionViewModel> GetSolutionsByUserId(int id)
        {

            //var solutionViewModels = dbCon.OrderSolutions
            //    .Join(dbCon.Users,
            //        solution => solution.Id,
            //        user => user.Id,
            //        (solution, user) => new OrderSolutionViewModel
            //        {
            //            CreatorUserName = user.UserName,
            //            Description = solution.Description
            //        })
            //    .ToList();
                var solutionViewModels = mapper.Map<IEnumerable<OrderSolutionViewModel>>(dbCon.OrderSolutions.Where(p => p.CreatorId == id)).ToList();
                string userName = dbCon.Users.Find(id).UserName;
                for (int i = 0; i < solutionViewModels.LongCount(); i++)
                    solutionViewModels[i].CreatorUserName = userName;

                return solutionViewModels;
        }
    }

}
