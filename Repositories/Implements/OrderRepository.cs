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

        public OrderRepository(ApplicationDbContext context)             
        {
            dbCon = context;
        }

        public void Add(Order item)
        {
            dbCon.Orders.Add(item);
            dbCon.SaveChanges();
        }

        public void Delete(Order item)
        {
            dbCon.Orders.Remove(item);
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

        public void Update(Order order)
        {
           dbCon.Entry(order).State = EntityState.Modified;
            dbCon.SaveChanges();
        }
    }

}
