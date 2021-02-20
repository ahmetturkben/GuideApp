using Guide.BL.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.BL.Base
{
    public class BaseBLModel : IBaseBLModel
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }


        public void SetCreatedDetail()
        {
            CreatedDate = DateTime.Now;
        }

    }
}
