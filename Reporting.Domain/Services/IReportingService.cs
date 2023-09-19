using Reporting.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporting.Domain.Services
{
    public interface IReportingService
    {
        List<ReportingDTO> GetReport();
    }
}
