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
            services.AddScoped<IHallService<int>, HallService>();
            services.AddScoped<IPerfomanceService<int>, PerfomanceService>();
            services.AddScoped<ITicketService<int>, TicketService>();
            services.AddScoped<IBookingService<int>, BookingService>();
            services.AddScoped<IPlaceService<int>, PlaceService>();
            return services;
        }
    }
}
