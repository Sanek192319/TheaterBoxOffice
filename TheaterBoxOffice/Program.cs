using BL;
using BL.Abstraction;
using DAL;
using DAL.Entites;
using DAL.UnitOfWork.Abstraction;
using DataModel;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TheaterBoxOffice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.SetEFDataDependencies();
            services.SetServices();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var Services = serviceProvider.GetRequiredService<IPerfomanceService<int>>();
            var AddSomething = serviceProvider.GetRequiredService<IUnitOfWork>();
            var entity = new PerfomanceEntity() 
            {
                Id = 1,
                AuthurName = "bob",
                GenreId = 1,
                PerfomanceName = "name1",
                HallId = 1
            };
            var genre = new GenreEntity()
            {
                Id = 1,
                GenreName = "nameOfGenre"
            };
            var hall = new HallEntity()
            {
                Id = 1,
                Number = 2
            };

            AddSomething.PerfomanceRepository.Create(entity);
            AddSomething.GenreRepository.Create(genre);
            AddSomething.HallRepository.Create(hall);
            AddSomething.Save();
            var result = Services.GetPerfomanceByAuthor("bob");
            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.AuthurName);
            }
        }
    }
}
