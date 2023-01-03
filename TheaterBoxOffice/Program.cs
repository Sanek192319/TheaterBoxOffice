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
                Id = 3,
                AuthurName = "bob",
                GenreId = 1,
                PerfomanceName = "name1",
                HallId = 1,
                PerfomanceDate = new DateTime(2003, 4, 15)
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
            var place = new PlaceEntity()
            {
                Id = 1,
                Price = 100,
                HallId = 1
            };

            AddSomething.PerfomanceRepository.Create(entity);
            AddSomething.GenreRepository.Create(genre);
            AddSomething.HallRepository.Create(hall);
            AddSomething.PlaceRepository.Create(place);
            AddSomething.Save();
            var result = Services.GetPerfomanceByAuthor("bob");
            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.AuthurName);
            }
            // var result2 = Services.GetPerfomanceByName("name1");
            // foreach (var item in result2)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.PerfomanceName);
            // }
            // var result3 = Services.GetPerfomanceByGenre("nameOfGenre");
            // foreach (var item in result3)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.PerfomanceName);
            // }
            // Console.WriteLine("result 4");
            // var result4 = Services.GetPerfomanceByDate(new DateTime(2003,4,15));
            // foreach (var item in result4)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.PerfomanceName);
            //     Console.WriteLine(item.PerfomanceDate);
            // }
            // //var Services2 = serviceProvider.GetRequiredService<IUserService<int>>();
            // //var userid = Services2.CreateUser("igorb5");
            // var Services3 = serviceProvider.GetRequiredService<ITicketService<int>>();
            //// Services3.BuyTicket(3, 1,3);
            // var Services4 = serviceProvider.GetRequiredService<IBookingService<int>>();
            // //Services4.BookTicket(1, 2,userid);
            //// Services4.BookTicket(1, 1, userid);
            // //Services4.SellBookedTicket(1, 2, 3);

            //var Services4 = serviceProvider.GetRequiredService<IPlaceService<int>>();
            //var result = Services4.GetAllAvaliablePlaces(1, 1);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.PlaceNumber);
            //    Console.WriteLine(item.price);
            //}
            //var result2 = Services.GetPerfomanceByGenre("Hist");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.PerfomanceName);
            //}
        }
    }
}
