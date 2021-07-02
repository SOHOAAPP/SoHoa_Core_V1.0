using Microsoft.Extensions.DependencyInjection;
using SoHoa.Infrastructure.Common;
using SoHoa.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDateTime, ServerDateTime>();
            return services;
        }
    }
}
