using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;
using User.Domain.Models;

namespace User.Domain.Services
{
    public interface IUserService
    {
        List<User.Domain.Models.User> GetAll();
        int Add(User.Domain.Models.User user);
        int Update(User.Domain.Models.User user);
        bool Delete(int id);
        User.Domain.Models.User GetUserById(int id);
        List<UserDetailModel> GetUserDetails();
        List<UserDetailModel> GetUserDetailsByUserId(int userId);
    }
}

