using Confluent.Kafka;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Reporting.Domain.Services;

namespace Reporting.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReportingController : BaseController
    {
       
        IReportingService _reportingService;
        public ReportingController(IReportingService reportingService, ProducerConfig configuration, IConfiguration config):base(configuration, config)
        {
            _reportingService = reportingService;          
        }

        [HttpGet("getreport")]
        public ActionResult GetReport()
        {
            
            var result = _reportingService.GetReport();
            ProduceAsync(result.First());
            //Get(result.First());
            return Ok(result);
        }
    }
}
