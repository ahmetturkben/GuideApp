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
        private IContactRepository _contactRepository;
        public ReportService(IMapper mapper,
            IReportRepository reportRepository,
            IContactRepository contactRepository) : base(mapper, reportRepository)
        {
            _contactRepository = contactRepository;
        }

        public bool SendReportRequest(string personId)
        {
            BL.Report report = Add(new BL.Report
            {
                ReportStatus = "Hazırlanıyor",
                RequestDate = DateTime.Now,
                Location = _contactRepository.Table.FirstOrDefault(x => x.ContactType == 30)?.ContactContent ?? string.Empty
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

        public int GetAllLocationRegisterPersonCount(string location, string personId)
        {
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(personId))
                return 0;

            return _contactRepository.Table.Where(x => x.ContactType == 30 && 
                                                  x.ContactContent == location && 
                                                  x.PersonId != personId).Select(x => x.PersonId).Distinct().Count();
        }

        public int GetAllLocationRegisterPhoneCount(string location, string personId)
        {
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(personId))
                return 0;

            return _contactRepository.Table.Where(x => x.ContactType == 20 &&
                                                  x.ContactContent == location &&
                                                  x.PersonId != personId).Select(x => x.ContactContent).Distinct().Count();
        }
    }
}
