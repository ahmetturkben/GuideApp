using AutoMapper;
using Guide.Data.Interfaces;
using Guide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Guide.Service.Services
{
    public class ReportService : ServiceBase<Data.Entities.Report, BL.Report>, IReportService
    {
        public ReportService(IMapper mapper,
            IReportRepository reportRepository) : base(mapper, reportRepository)
        {
        }

        public bool SendReportRequest()
        {
            BL.Report report = Add(new BL.Report
            {
                ReportStatus = "Hazırlanıyor",
                RequestDate = DateTime.Now
            });

            return true;
        }

        public List<string> GetAllProccessing()
        {
            return _repo.Table.Where(x => x.ReportStatus == "Hazırlanıyor").Select(x => x.Id).ToList();
        }

        public List<BL.Report> GetAllCompleted()
        {
            return _mapper.Map<List<BL.Report>>(_repo.Table.Where(x => x.ReportStatus == "Tamamlandı").ToList());
        }
    }
}
