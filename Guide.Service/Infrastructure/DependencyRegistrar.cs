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

            service.AddScoped<IPersonRepository, PersonRepository>();
            service.AddScoped<IContactRepository, ContactRepository>();
        }
    }
}
