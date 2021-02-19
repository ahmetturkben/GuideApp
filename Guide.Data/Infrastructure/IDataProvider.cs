using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Data.Infrastructure
{
    public interface IDataProvider
    {
        public string ConnectionString { get; }
    }
}
