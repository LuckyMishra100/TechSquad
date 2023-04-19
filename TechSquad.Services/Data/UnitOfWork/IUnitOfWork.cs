using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSquad.Services.Data.IRepository;

namespace TechSquad.Services.Data
{
   public  interface IUnitOfWork
    {
        IGenericRepository<T> GenericRepository<T>() where T : class;
        void save();
    }
}
