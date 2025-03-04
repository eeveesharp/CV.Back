﻿using CV.BLL.Interfaces;
using CV.BLL.Services;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BllServiceCollection
    {
        public static void AddBllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeServices, EmployeeServices>();
            services.AddScoped<IProjectServices, ProjectServices>();
            services.AddDalServices(configuration);
        }
    }
}
