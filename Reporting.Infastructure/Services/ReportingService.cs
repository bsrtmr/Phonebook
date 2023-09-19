using DataAccess.EntityFramework;
using Reporting.Domain.Models;
using Reporting.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting.Infastructure.Services
{
    public class ReportingService : IReportingService
    {
        IUserDal _userDal;
        public ReportingService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<ReportingDTO> GetReport()
        {
           return _userDal.GetReport();
        }
    }
}
