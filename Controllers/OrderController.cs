using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrialFreelance.Entities;
using TrialFreelance.Enums;
using TrialFreelance.Models;
using TrialFreelance.Repositories.Interfaces;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPreOrderRepository preOrderRepository;
        private readonly IOrderRepository orderRepository;
        private readonly UserManager<DbUser> userManager;
        public OrderController(IPreOrderRepository preOrderRepository, IOrderRepository orderRepository, UserManager<DbUser> userManager)
        {
            this.userManager = userManager;
            this.preOrderRepository = preOrderRepository;
            this.orderRepository = orderRepository;
        }
        public IActionResult OrdersList()
        {
                if (User.IsInRole("Admin"))
                    ViewBag.Role = "Admin";
            return View(preOrderRepository.GetAll());
        }

        public IActionResult Order(int id)
        {
            var order = orderRepository.FindById(id);

            if (order == null)
            {
                ViewBag.Error = $"Замовлення з id = {id} не знайдено";
                return View("Error");
            }

            return View(order);
        }

        public IActionResult UserOrders(int id=-1)
        {
            if (id == -1)
                id = Int32.Parse(userManager.GetUserId(this.User));

            var orders = preOrderRepository.FindOrdersByUserId(id);

            return View(orders);
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    DbLink = model.DbLink,
                    Description = model.Description,
                    Difficulty = model.Difficulty,
                    ExampleLink = model.ExampleLink,
                    GitHubLink = model.GitHubLink,
                    MainTask = model.MainTask,
                    Name = model.Name,
                    OwnerId = Int32.Parse(userManager.GetUserId(this.User)),
                    SecondaryTasks = model.SecondaryTasks,
                    Status = 1,
                };

                orderRepository.Add(order);
                return RedirectToAction("Order", "UserOrders");
            }
            ViewBag.Error = "Model is invalid";
            return View("Error");
        }

  
        [HttpGet]
        public IActionResult EditOrder(int id)
        {
            var order = orderRepository.FindById(id);

            if (order == null)
            {
                ViewBag.Error = $"Замовлення з id = {id} не знайдено";
                return View("Error");
            }

            var model = new EditOrderViewModel
            {
                DbLink = order.DbLink,
                Description = order.Description,
                Difficulty = order.Difficulty,
                ExampleLink = order.ExampleLink,
                GitHubLink = order.GitHubLink,
                MainTask = order.MainTask,
                Name = order.Name,
                OwnerId = order.OwnerId,
                SecondaryTasks = order.SecondaryTasks,
                Status = order.Status,
                CreatorId = order.CreatorId,
        };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditOrder(EditOrderViewModel model)
        {
            var order = orderRepository.FindById(model.Id);

            if (order == null)
            {
                ViewBag.Error = $"Замовлення з id = {model.Id} не знайдено";
                return View("Error");
            }
            else
            {
                order.DbLink = model.DbLink;
                order.Description = model.Description;
                order.Difficulty = model.Difficulty;
                order.ExampleLink = model.ExampleLink;
                order.GitHubLink = model.GitHubLink;
                order.MainTask = model.MainTask;
                order.Name = model.Name;
                order.OwnerId = model.OwnerId;
                order.SecondaryTasks = model.SecondaryTasks;
                order.Status = model.Status;
                order.CreatorId= order.CreatorId;

                orderRepository.Update(order);
                
                return RedirectToAction("OrdersList"); 
            }
        }

        public IActionResult DeleteOrder(int Id)
        {
            var order = orderRepository.FindById(Id);

            if (order != null)
            {
                orderRepository.Delete(order);
                return RedirectToAction("OrdersList");
            }
            ViewBag.ErrorMessage = $"Замовлення з id = {Id} не знайдено";
            return View("Error");
        }
    }
}
