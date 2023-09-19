using Reporting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using User.Domain.ModelDtos;
using User.Domain.Models;

namespace DataAccess.EntityFramework
{
    public interface IUserDal : IEntityRepository<User.Domain.Models.User>
    {
        List<UserDetailModel> GetUserDetails(Expression<Func<UserDetailModel, bool>> filter = null);
        List<ReportingDTO> GetReport();
    }
}
