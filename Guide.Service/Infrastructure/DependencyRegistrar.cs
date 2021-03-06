﻿using AutoMapper;
using Guide.Data.Infrastructure;
using Guide.Data.Interfaces;
using Guide.Data.Repositories;
using Guide.Service.Interfaces;
using Guide.Service.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Guide.Service.Infrastructure
{
    public static class DependencyRegistrar
    {
        public static void AddServiceRegistrar(this IServiceCollection service)
        {
            service.AddScoped<IPersonService, PersonService>();
            service.AddScoped<IContactService, ContactService>();
            service.AddScoped<IReportService, ReportService>();

            service.AddScoped<IPersonRepository, PersonRepository>();
            service.AddScoped<IContactRepository, ContactRepository>();
            service.AddScoped<IReportRepository, ReportRepository>();

            service.AddSingleton<IDataProvider, MongoDBDataProvider>();
            service.AddScoped<ICodeFirstInstallation, CodeFirstInstallation>();

            service.AddScoped<IUserService, UserService>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
