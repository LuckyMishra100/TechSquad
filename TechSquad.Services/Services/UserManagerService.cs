using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSquad.Models.Models;
using TechSquad.Models.ViewModels;
using TechSquad.Services.Data;
using TechSquad.Services.IServices;

namespace TechSquad.Services.Services
{
  
    public class UserManagerService : IUserManagerService
    {
        private readonly ILogger<UserManagerService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public UserManagerService(ILogger<UserManagerService> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        //public async Task<AspNetUser> AddUserAsync(AspNetUser model)
        //{
        //    try
        //    {
        //        AspNetUser res = null;
        //        if (model.Id != "0")
        //        {
        //            res = await _unitOfWork.GenericRepository<AspNetUser>().UpdateAsync(model);
        //        }
        //        else
        //        {
        //            res = await _unitOfWork.GenericRepository<AspNetUser>().AddAsync(model);
        //        }
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //public bool DeleteUser(int id)
        //{
        //    try
        //    {
        //        _unitOfWork.GenericRepository<AspNetUser>().DeleteByID(id);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //public IEnumerable<AspNetUser> GetAllUser()
        //{
        //    try
        //    {
        //        var res = _unitOfWork.GenericRepository<AspNetUser>().GetAll();
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}

        //public Task<AspNetUser> GetUserById(int id)
        //{
        //    try
        //    {
        //        var res = _unitOfWork.GenericRepository<AspNetUser>().GetByIdAsync(id);
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
