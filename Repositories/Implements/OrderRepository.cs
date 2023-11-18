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
    public class OrderRepository : IOrderRepository
    {
        private ApplicationDbContext dbCon;
        private DbContextOptions<ApplicationDbContext> options;

        public OrderRepository(ApplicationDbContext context, DbContextOptions<ApplicationDbContext> options)             
        {
            dbCon = context;
            this.options = options;
        }

        public void Add(Order item)
        {
            dbCon.Orders.Add(item);
            dbCon.SaveChanges();
        }

        public void Delete(Order model)
        {
            dbCon.Orders.Remove(model);
            dbCon.SaveChanges();
        }

        public Order FindById(int id)
        {
            return dbCon.Orders.Find(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return dbCon.Orders;
        }

        public List<string> GetNames()
        {
            return new ApplicationDbContext(options).Orders.Select(p=>p.Name).ToList();
        }

        public void Update(Order order)
        {
           dbCon.Entry(order).State = EntityState.Modified;
            dbCon.SaveChanges();
        }
    }

}
