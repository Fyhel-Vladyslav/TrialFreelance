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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<DbUserRole>(userRole =>
        //    {
        //        userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

        //        userRole.HasOne(ur => ur.Role)
        //            .WithMany(r => r.UserRoles)
        //            .HasForeignKey(ur => ur.RoleId)
        //            .IsRequired();

        //        userRole.HasOne(ur => ur.User)
        //            .WithMany(r => r.UserRoles)
        //            .HasForeignKey(ur => ur.UserId)
        //            .IsRequired();
        //    });
        //}
    }
}

