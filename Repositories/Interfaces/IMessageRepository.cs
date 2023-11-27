using System.Collections.Generic;
using TrialFreelance.Entities;
using TrialFreelance.Models;
using TrialFreelance.ViewModels;

namespace TrialFreelance.Repositories.Interfaces
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        public IEnumerable<MessageViewModel> GetMessagesByUserId(int id);
        public void SetMessagesRead(List<int> ids);
        public IEnumerable<PreMessageViewModel> GetPreMessages(int id);

    }
}
