using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;
using TrialFreelance.Entities;
using TrialFreelance.Models;

namespace TrialFreelance.Data
{
    public class ApplicationDbContext : IdentityDbContext<DbUser, DbRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderSolution> OrderSolutions { get; set; }

    }
}

