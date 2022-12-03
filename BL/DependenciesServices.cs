using BL.Abstraction;
using BL.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public static  class DependenciesServices
    {
        public static IServiceCollection SetServices(this IServiceCollection services)
        {
            services.AddScoped<IPerfomanceService<int>, PerfomanceService>();
            return services;
        }
    }
}
