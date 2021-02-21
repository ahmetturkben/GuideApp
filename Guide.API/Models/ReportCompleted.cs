using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.API.Models
{
    public class ReportCompleted
    {
        public string Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string ReportStatus { get; set; }
        public int LocationGuidRegisterPersonCount { get; set; }
        public int LocationGuidRegisterPhoneCount { get; set; }
    }
}
