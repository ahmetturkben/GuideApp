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
    public class ReportProccessingController : Controller
    {
        private readonly IReportService _reportService;
        public ReportProccessingController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_reportService.GetAllProccessing());
        }


    }
}
