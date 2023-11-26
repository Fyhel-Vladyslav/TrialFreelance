using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Data;
using System.Threading.Tasks;
using TrialFreelance.Entities;
using TrialFreelance.Enums;
using TrialFreelance.Migrations;
using TrialFreelance.Models;
using TrialFreelance.Repositories.Implements;
using TrialFreelance.Repositories.Interfaces;

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
                PostDate = DateTime.Today.AddDays(-1).ToString(),
                SolutionId = model.SolutionId
            };

            messageRepository.Add(message);
            return true;
        }

        [HttpPost]
        public IActionResult SetMessageRead(int id, bool setAllRead = false)
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            if (setAllRead)// if setAllRead==1 then in id we sent id of user
            {
                var userMessages = messageRepository.GetMessagesByUserId(id);
                if(userMessages != null)
                {
                    foreach(var message in userMessages)
                    {
                        list.Add(message.Id);
                    }
                }
            }
            else// if setAllRead==0 then in id we sent id of message
                list.Add(id);

            messageRepository.SetMessagesRead(list);
            return RedirectToAction("UserMessages");
        }
    }
}



//If you are using Npgsql (the.NET data provider for PostgreSQL) and encountering the "Connection is busy" issue, you can consider the following Npgsql-specific tips:

//Async / Await Patterns:

//Npgsql supports asynchronous programming, so make sure that you are using the asynchronous methods when appropriate. Check that you are awaiting asynchronous calls properly.
//Connection Pooling:

//Npgsql uses connection pooling by default. Make sure that you are disposing of Npgsql connections properly after use. The using statement is a good way to ensure that the connection is properly closed and returned to the pool.
//csharp
//Copy code
//using (var connection = new NpgsqlConnection(connectionString))
//{
//    await connection.OpenAsync();

//    // Perform database operations here

//} // Connection is automatically closed and returned to the pool
//Concurrency Issues:

//If you are working with multiple threads, ensure that you are not sharing Npgsql connections across threads. Each thread should have its own connection.
//Check Connection State:

//Before opening a connection, check if it's closed. This is important to avoid attempting to open an already open connection.
//csharp
//Copy code
//using (var connection = new NpgsqlConnection(connectionString))
//{
//    if (connection.State == ConnectionState.Closed)
//    {
//        await connection.OpenAsync();
//    }

//    // Perform database operations here

//} // Connection is automatically closed and returned to the pool
//Transaction Handling:

//If you are using transactions, ensure that you are properly committing or rolling back transactions and closing the connection afterward.
//csharp
//Copy code
//using (var connection = new NpgsqlConnection(connectionString))
//{
//    await connection.OpenAsync();

//    using (var transaction = connection.BeginTransaction())
//    {
//        try
//        {
//            // Perform transactional database operations here

//            transaction.Commit();
//        }
//        catch
//        {
//            transaction.Rollback();
//            throw;
//        }
//    }
//}