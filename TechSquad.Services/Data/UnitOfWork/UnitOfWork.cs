using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSquad.Application.Data;
using TechSquad.Services.Data.IRepository;
using TechSquad.Services.Data.Repository;

namespace TechSquad.Services.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context = null;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repo = new GenericRepository<T>(_context);
            return repo;
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
