using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TechSquad.Services.Data.IRepository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(object id);

        Task<T> GetByIdAsync(object id);
        void Add(T entity);
        Task<T> AddAsync(T entity);
        void DeleteByID(object id);

        void Delete(T entityToDelete);

        void Update(T entityToUpdate);

        Task<T> UpdateAsync(T entityToUpdate);

        Task<T> DeleteAsync(T entityToDelete);
    }
}
