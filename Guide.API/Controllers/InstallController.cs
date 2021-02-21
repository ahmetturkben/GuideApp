using Guide.Data.Infrastructure;
using Guide.Service.Infrastructure;
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
    public class InstallController : Controller
    {
        public ICodeFirstInstallation _codeFirstInstallation { get; set; }
        public IDataProvider _dataProvider { get; set; }
        public InstallController(ICodeFirstInstallation codeFirstInstallation,
            IDataProvider dataProvider)
        {
            _codeFirstInstallation = codeFirstInstallation;
            _dataProvider = dataProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _codeFirstInstallation.CreateTables("tr", _dataProvider.ConnectionString);
            return Ok();
        }


    }
}
