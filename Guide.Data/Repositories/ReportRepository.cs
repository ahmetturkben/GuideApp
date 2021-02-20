using Guide.Data.Entities;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Repositories
{
    public class ReportRepository : RepositoryBase<Report>, IReportRepository
    {
        public ReportRepository(IDataProvider dataProvider) :base(dataProvider)
        {

        }
    }
}
