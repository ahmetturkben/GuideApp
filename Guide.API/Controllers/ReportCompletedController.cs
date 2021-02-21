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

        [HttpGet("{personId}")]
        public IActionResult Get(string personId)
        {
            var reports = _reportService.GetAllCompleted();

            List<Models.ReportCompleted> models = new List<Models.ReportCompleted>();
            foreach (var item in reports)
            {
                models.Add(new Models.ReportCompleted
                {
                    Id = item.Id,
                    ReportStatus = item.ReportStatus,
                    RequestDate = item.RequestDate,
                    LocationGuidRegisterPersonCount = _reportService.GetAllLocationRegisterPersonCount(item.Location, personId),
                    LocationGuidRegisterPhoneCount = _reportService.GetAllLocationRegisterPhoneCount(item.Location, personId)
                });
            }

            return Ok();
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
