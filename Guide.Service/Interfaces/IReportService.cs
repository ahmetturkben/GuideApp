using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Interfaces
{
    public interface IReportService : IService<Data.Entities.Report, BL.Report>
    {
        bool SendReportRequest();
        List<string> GetAllProccessing();
        List<BL.Report> GetAllCompleted();
    }
}
