using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using TrialFreelance.Data;
using TrialFreelance.Models;

namespace TrialFreelance.Entities
{
    public class Seeder
    {
        public static async Task SeedDataAsync(IServiceProvider services,
            IWebHostEnvironment env, IConfiguration config)
        {
            try
            {
                using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                    var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    string email;
                    DbUser user;
                    var result = managerRole.CreateAsync(new DbRole
                    {
                        Name = "Admin"
                    }).Result;

                    result = managerRole.CreateAsync(new DbRole
                    {
                        Name = "User"
                    }).Result;

                    result = managerRole.CreateAsync(new DbRole
                    {
                        Name = "Manager"
                    }).Result;

                    email = "admin@gmail.com";
                    user = await manager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new DbUser
                        {
                            Email = email,
                            FirstName = "Валадій",
                            LastName = "Фугас",
                            UserName = email,
                            PhoneNumber = "+380476758769",
                            Birthday = "12-05-1991",
                            FinishedOrders = 7,
                            GitHubPageLink = "https//github.com"
                        };
                        result = manager.CreateAsync(user, "@123Admin").Result;
                        result = manager.AddToRoleAsync(user, "Admin").Result;
                        context.SaveChanges();
                    }

                    email = "manager@gmail.com";
                    user = await manager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new DbUser
                        {
                            Email = email,
                            FirstName = "Рік",
                            LastName = "Санчез",
                            UserName = email,
                            PhoneNumber = "+380493438481",
                            Birthday = "19-12-4995",
                            FinishedOrders = 7,
                            GitHubPageLink = "https//github.com"
                        };
                        result = manager.CreateAsync(user, "@123Manager").Result;
                        result = manager.AddToRoleAsync(user, "Manager").Result;

                        context.SaveChanges();
                    }

                    email = "user@gmail.com";
                    user = await manager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new DbUser
                        {
                            Email = email,
                            FirstName = "Нейм",
                            LastName = "Снейм",
                            UserName = email,
                            PhoneNumber = "+380476758769",
                            Birthday = "97-98-0990",
                            FinishedOrders = 7,
                            GitHubPageLink = "johijk"
                        };
                        result = manager.CreateAsync(user, "@123User").Result;
                        result = manager.AddToRoleAsync(user, "User").Result;

                        context.SaveChanges();
                    }

                    if (!context.Orders.Any())
                    {
                        var orders = new List<Order>
                {
                    new Order
                    {

                        Name = "Новий сайт",
                        Difficulty = 4,
                        Status = 1,
                        OwnerId = 46,
                        ExampleLink="https://phasmophobia.fandom.com/ru/wiki/%D0%94%D0%B5%D1%82%D0%B5%D0%BA%D1%82%D0%BE%D1%80_%D0%AD%D0%9C%D0%9F_(%D1%83%D1%80._5)",
                        GitHubLink="https://github.com/dotnet/efcore/issues/20549",
                        DbLink="",
                        MainTask = "Зробити взаємодію на сайті",
                        SecondaryTasks = "Відреданувати баги при маштабуванні",
                        Description = "Потрібно зробити майт з інформацію про інровий свіи, лор, предмети і ін."
                    },
                    new Order
                    {
                        Name = "Програма",
                        Difficulty = 1,
                        Status = 2,
                        OwnerId = 86,
                        ExampleLink="bla",
                        GitHubLink="bla",
                        DbLink="bla",
                        MainTask = "Site",
                        SecondaryTasks = "tasks",
                        Description = "tasks"
                    },
                    new Order
                    {
                        Name = "Клон ютуба",
                        Difficulty = 10,
                        Status = 0,
                        OwnerId = 23,
                        ExampleLink="bla",
                        GitHubLink="bla",
                        DbLink="bla",
                        MainTask = "Site",
                        SecondaryTasks = "tasks",
                        Description = "tasks"
                    }
                };
                        context.Orders.AddRange(orders);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
