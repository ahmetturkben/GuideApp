using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Entities
{
    public class Report : BaseEntity
    {
        public DateTime RequestDate { get; set; }
        public string ReportStatus { get; set; }

    }
}
