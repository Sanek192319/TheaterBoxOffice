using DAL.Repositories.Abstraction;
using DAL.Repositories.Realisation;
using DAL.UnitOfWork.Abstraction;
using DAL.UnitOfWork.Realisation;
using Microsoft.Extensions.DependencyInjection;
namespace DAL
{
    public static class DependenciesEFData
    {
        public static IServiceCollection SetEFDataDependencies(this IServiceCollection services)
        {
            services.AddScoped<TheaterBoxOfficeDbContext>();
            services.AddScoped<IPerfomanceRepository, EFPerfomanceRepository>();
            services.AddScoped<IBookingRepository, EFBookingRepository>();
            services.AddScoped<IGenreRepository,EFGenreRepository>();
            services.AddScoped<IHallRepository,EFHallRepository>();
            services.AddScoped<IPlaceRepository,EFPlaceRepository>();
            services.AddScoped<ITicketRepository,EFTicketRepository>();
            services.AddScoped<IUserRepository,EFUserRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();
            return services;
        }
    }
}
