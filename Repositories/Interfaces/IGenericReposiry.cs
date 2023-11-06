using System.Collections.Generic;
using TrialFreelance.Models;

namespace TrialFreelance.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity FindById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity model);
        void Delete(Order model);
        void Update(TEntity model);
    }
}
