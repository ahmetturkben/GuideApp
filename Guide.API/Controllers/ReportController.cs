using Guide.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Guide.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            bool result = _reportService.SendReportRequest();
            if (result) return Ok();
            return BadRequest();
        }
    }
}
