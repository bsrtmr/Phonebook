using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;
using User.Domain.Services;

namespace User.Infastructure.Services
{
    public class UserService : IUserService
    {
        IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public int Add(Domain.Models.User user)
        {
            _userDal.Add(user);
            return user.id;
        }
        public List<Domain.Models.User> GetAll()
        {
           return _userDal.GetAll();
        }

        public bool Delete(int id)
        {
            _userDal.Delete(c => c.id == id);
            return true;
        }

        public int Update(Domain.Models.User user)
        {
            _userDal.Update(user);
            return user.id;
        }

        public Domain.Models.User GetUserById(int id)
        {
            return _userDal.Get(c => c.id == id);
        }

        public List<UserDetailModel> GetUserDetails()
        {
            return _userDal.GetUserDetails();
        }

        public List<UserDetailModel> GetUserDetailsByUserId(int userId)
        {
            return _userDal.GetUserDetails(c=> c.id == userId);
        }
    }
}
