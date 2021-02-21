using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Interfaces
{
    public interface IReportService : IService<Data.Entities.Report, BL.Report>
    {
        bool SendReportRequest(string personId);
        List<string> GetAllProccessing();
        List<BL.Report> GetAllCompleted();
        int GetAllLocationRegisterPersonCount(string location, string personId);
        int GetAllLocationRegisterPhoneCount(string location, string personId);
    }
}
