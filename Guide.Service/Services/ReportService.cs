using Guide.Service.Interfaces;
using System;
using System.Net.Http;

namespace Guide.Service.Services
{
    public class ReportService : IReportService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ReportService(IHttpClientFactory httpClientFactory)
        {
            _clientFactory = httpClientFactory;
        }
        public bool SendReportRequest()
        {

            throw new NotImplementedException();
        }
    }
}
