using DAL.Repositories.Abstraction;
using DAL.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork.Realisation
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private TheaterBoxOfficeDbContext _dbContext;

        public EFUnitOfWork(TheaterBoxOfficeDbContext dbContext, IBookingRepository bookingRepository, IGenreRepository genreRepository,
            IHallRepository hallRepository, IPerfomanceRepository perfomanceRepository, IPlaceRepository placeRepository, ITicketRepository ticketRepository, IUserRepository userRepository)
        {
            _dbContext = dbContext;
            BookingRepository = bookingRepository;
            GenreRepository = genreRepository;
            HallRepository = hallRepository;
            PerfomanceRepository = perfomanceRepository;
            PlaceRepository = placeRepository;
            TicketRepository = ticketRepository;
            UserRepository = userRepository;
        }

        public IBookingRepository BookingRepository { get; set; }
        public IGenreRepository GenreRepository { get; set; }
        public IHallRepository HallRepository { get; set; }
        public IPerfomanceRepository PerfomanceRepository { get; set; }
        public IPlaceRepository PlaceRepository { get; set; }
        public ITicketRepository TicketRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        ~EFUnitOfWork()
        {
            _dbContext.Dispose();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
