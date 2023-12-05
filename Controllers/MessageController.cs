using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using TrialFreelance.Entities;
using TrialFreelance.Enums;
using TrialFreelance.Migrations;
using TrialFreelance.Models;
using TrialFreelance.Repositories.Implements;
using TrialFreelance.Repositories.Interfaces;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Controllers
{
    public class MessageController : Controller
    {
        private UserManager<DbUser> userManager;
        private IMessageRepository messageRepository;
        private IOrderSolutionRepository solutionRepository;

        public MessageController(UserManager<DbUser> userManager, IMessageRepository messageRepository, IOrderSolutionRepository solutionRepository)
        {
            this.userManager = userManager;
            this.messageRepository = messageRepository;
            this.solutionRepository = solutionRepository;
        }
        public async Task<IActionResult> UserMessages(int id = -1)
        {
            DbUser user;
            if (id == -1)
                user = await userManager.GetUserAsync(User);
            else
                user = await userManager.FindByIdAsync(id.ToString());

            if (user != null)
            {
                var messages = messageRepository.GetMessagesByUserId(user.Id);
                if (User.IsInRole("Admin"))
                    ViewBag.Role = "Admin";

                return View(messages);
            }
            ViewBag.Error = "Користувача не знайдено або не автоизовано";
            return View("Error");
        }

        [HttpGet]
        public IActionResult AddMessage(int id=0)
        {
            return View(new Message() { UserId = id });
        }
        [HttpPost]
        public IActionResult AddMessage(Message model)
        {
            if (ModelState.IsValid)
            {
                SendMessage(model);
                return RedirectToAction("OrdersList", "Order");
            }
            return View("Error");
        }
        [HttpPost]
        public bool SendMessage(Message model)
        {
            if (model.SolutionId != 0)
            {
                var soution = solutionRepository.FindById(model.SolutionId);
                if (soution != null)
                    model.OrderId = soution.OrderId;

            }
            else
                model.OrderId = 0;

            var message = new Message()
            {
                UserId = model.UserId,
                OrderId = model.OrderId,
                MesText = model.MesText,
                MesType = model.SolutionId == 0 ? (int)MessageTypes.System : (int)MessageTypes.Solution,
                PostDate = DateTime.Now.ToString("yyyy-MM-dd"),
                SolutionId = model.SolutionId
            };

            messageRepository.Add(message);
            return true;
        }

        [HttpPost]
        public IActionResult SetMessageRead([FromBody] SetMessageReadModel model)
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            if (model.SetAllRead)// if setAllRead==1 then in id we sent id of user
            {
                var userMessages = messageRepository.GetMessagesByUserId(model.id);
                if(userMessages != null)
                {
                    foreach(var message in userMessages)
                    {
                        list.Add(message.Id);
                    }
                }
            }
            else// if setAllRead==0 then in id we sent id of message
                list.Add(model.id);

            messageRepository.SetMessagesRead(list);
            return RedirectToAction("UserMessages");
        }
        [HttpGet]
        public IActionResult EditMessage(int id)
        {
            var message = messageRepository.FindById(id);
            if (message != null)
            {
                var model = new MessageViewModel
                {
                    MesText = message.MesText,
                     UserId = message.UserId,
                    Id = message.Id,
                     SolutionId = message.SolutionId,
                    OrderId = message.OrderId,
                     PostDate = message.PostDate,
                      MesType = message.MesType,
                      isRead = message.isRead,
                };
                return View(model);
            }
            ViewBag.Error = "Такого повідомлення не існує";
            return View("Error");
        }
        [HttpPost]
        public IActionResult EditMessage(MessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var message = messageRepository.FindById(model.Id);
                if(message!=null)
                {
                    message.MesText = model.MesText;
                    message.UserId = model.UserId;
                    message.SolutionId = model.SolutionId;
                    message.OrderId = model.OrderId;
                    message.PostDate = model.PostDate;
                    message.MesType = model.MesType;
                    message.isRead = model.isRead;

                    messageRepository.Update(message);
                return RedirectToAction("UserSolutions");
            }
                ViewBag.Error = "Такого повідомлення не існує";
                return View("Error");
            }
            ViewBag.Error = "Model is invalid";
            return View("Error");
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = messageRepository.FindById(id);

            if (message != null)
            {
                messageRepository.Delete(message);
                return RedirectToAction("UserMessages");
            }
            ViewBag.ErrorMessage = $"Замовлення з id = {id} не знайдено";
            return View("Error");
        }

        public class SetMessageReadModel
        {
            public int id { get; set; }
            public bool SetAllRead { get; set; }
        }
    }
}