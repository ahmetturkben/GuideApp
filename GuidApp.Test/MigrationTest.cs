using Guide.Data.Infrastructure;
using Guide.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuidApp.Test
{
    public class MigrationTest
    {
        private readonly ICodeFirstInstallation _codeFirstInstallation;
        private readonly IDataProvider _dataProvider;
        public MigrationTest(ICodeFirstInstallation codeFirstInstallation, IDataProvider dataProvider)
        {
            _codeFirstInstallation = codeFirstInstallation;
            _dataProvider = dataProvider;
        }

        [Fact]
        public void Test1()
        {
            _codeFirstInstallation.CreateTables("tr", _dataProvider.ConnectionString);

        }
    }
}
