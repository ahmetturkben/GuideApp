using Guide.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ReportCompletedController : Controller
    {
        private readonly IReportService _reportService;
        public ReportCompletedController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_reportService.GetAllCompleted());
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id)
        {
            BL.Report report = _reportService.GetById(id);
            if (report == null)
                return NotFound();

            report.ReportStatus = "Tamamlandı.";
            _reportService.Update(report);

            return Ok();
        }
    }
}
