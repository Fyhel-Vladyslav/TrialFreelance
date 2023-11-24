using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TrialFreelance.Entities;
using TrialFreelance.Models;
using TrialFreelance.Repositories.Implements;
using TrialFreelance.Repositories.Interfaces;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Controllers
{
    public class SolutionController : Controller
    {
        private readonly IOrderSolutionRepository solutionRepository;
        private readonly IOrderRepository orderRepository;
        private readonly UserManager<DbUser> userManager;
        public SolutionController(IOrderRepository orderRepository, UserManager<DbUser> userManager, IOrderSolutionRepository solutionRepository)
        {
            this.orderRepository = orderRepository;
            this.solutionRepository = solutionRepository;
            this.userManager = userManager;
        }

        public IActionResult SolutionsList()
        {
            if (User.IsInRole("Admin"))
                ViewBag.Role = "Admin";
            return View(solutionRepository.GetAllSolutions());
        }


        [HttpPost]
        public async Task<IActionResult> CreateSolution(int orderId, string githubLink, string description)
        {
            var order = orderRepository.FindById(orderId);
            if (order != null)
            {
                DbUser user = await userManager.GetUserAsync(User);
                if (user != null)
                {
                    var solution = new OrderSolution { CreatorId = user.Id, Description = description, GitHubLink = githubLink, OrderId = orderId };
                    solutionRepository.Add(solution);
                    return RedirectToAction("ManageUser", "Account");
                }
            }
            ViewBag.Error = "Такого замовлення не існує";
            return View("Error");
        }
        public async Task<IActionResult> UserSolutions(int id = -1)
        {
            DbUser user;
            if (id == -1)
                user = await userManager.GetUserAsync(User);
            else
                user = await userManager.FindByIdAsync(id.ToString());

            if (user != null)
            {
                var solutions = solutionRepository.GetSolutionsByUserId(user.Id);
                if (User.IsInRole("Admin"))
                    ViewBag.Role = "Admin";

                return View(solutions);
            }
            ViewBag.Error = "Користувача не знайдено або не автоизовано";
            return View("Error");
        }

        public IActionResult OrderSolutions(int id)
        {
            

            if (id != 0)
            {
                var solutions = solutionRepository.GetSolutionsByOrderId(id).ToList();
                if (User.IsInRole("Admin"))
                    ViewBag.Role = "Admin";
                return View(solutions);
            }
            ViewBag.Error = "Такого замовлення не знайдено або не існує";
            return View("Error");
        }
        [HttpGet]
        public IActionResult EditSolution(int id)
        {
            var solution = solutionRepository.FindById(id);
            if (solution != null)
            {
                var model = new EditSolutionViewModel
                {
                    CreatorId = solution.CreatorId,
                    Description = solution.Description,
                    Id = solution.Id,
                    GitHubLink = solution.GitHubLink,
                    OrderId = solution.OrderId
                };
                return View(model);
            }
            ViewBag.Error = "Такого замовлення не існує";
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> EditSolution(EditSolutionViewModel model)
        {
            if (ModelState.IsValid)
            {

                var solution = new OrderSolution
                {

                    CreatorId = model.CreatorId,
                    Description = model.Description,
                    Id = model.Id,
                    GitHubLink = model.GitHubLink,
                    OrderId = model.OrderId
                };
                solutionRepository.Update(solution);
                var user = await userManager.GetUserAsync(User);
                user.FinishedOrders++;
                await userManager.UpdateAsync(user);
                return RedirectToAction("UserSolutions");
            }
            return View();
        }
        public IActionResult DeleteSolution(int id)
        {
            var solution = solutionRepository.FindById(id);

            if (solution != null)
            {
                solutionRepository.Delete(solution);
                return RedirectToAction("UserSolutions");
            }
            ViewBag.ErrorMessage = $"Замовлення з id = {id} не знайдено";
            return View("Error");
        }
    }
}
