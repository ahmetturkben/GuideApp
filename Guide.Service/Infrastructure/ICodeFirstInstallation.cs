using System;
using System.Collections.Generic;
using System.Text;

namespace Guide.Service.Infrastructure
{
    public interface ICodeFirstInstallation
    {
        void CreateTables(string local, string connectionString);
    }
}
