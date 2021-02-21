using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.BL
{
    public class Report : Base.BaseBLModel
    {
        public DateTime RequestDate { get; set; }
        public string ReportStatus { get; set; }
        public string Location { get; set; }
    }
}
