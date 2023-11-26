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
    public class MessageRepository : IMessageRepository
    {
        private ApplicationDbContext dbCon;
        private DbContextOptions<ApplicationDbContext> options;
        private readonly IMapper mapper;
        public MessageRepository(ApplicationDbContext context, IMapper mapper, DbContextOptions<ApplicationDbContext> options)
        {
            dbCon = context;
            this.options = options;
            this.mapper = mapper;
        }

        public void Add(Message message)
        {
            message.isRead = false;
            dbCon.Messages.Add(message);
            dbCon.SaveChanges();
        }

        public void Delete(Message model)
        {
            dbCon.Messages.Remove(model);
            dbCon.SaveChanges();
        }

        public Message FindById(int id)
        {
            return dbCon.Messages.Find(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return dbCon.Messages;
        }

        public void Update(Message message)
        {
            dbCon.Entry(message).State = EntityState.Modified;
            dbCon.SaveChanges();
        }

        public IEnumerable<MessageViewModel> GetMessagesByUserId(int id)
        {
            string userName = dbCon.Users.Find(id).UserName;
            var messageViewModels = mapper.Map<IEnumerable<MessageViewModel>>(dbCon.Messages.Where(p => p.UserId == id)).ToList();
            
            for (int i = 0; i < messageViewModels.Count(); i++)
                messageViewModels[i].UserName = userName;

            return messageViewModels;
        }

        public void SetMessagesRead(List<int> ids)
        {
            if (ids != null)
            {
                Message message;
                foreach (var id in ids)
                {
                    message = dbCon.Messages.Find(id);
                    if (message != null)
                    if (!message.isRead)
                    {
                        message.isRead = true;
                        Update(message);
                    }
                }
            }
        }
    }

}
