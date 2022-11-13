using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork.Abstraction
{
    public interface IUnitOfWork
    {
        public IBookingRepository BookingRepository { get; set; }
        public IGenreRepository GenreRepository { get; set; }
        public IHallRepository HallRepository { get; set; }
        public IPerfomanceRepository PerfomanceRepository { get; set; }
        public IPlaceRepository PlaceRepository { get; set; }
        public ITicketRepository TicketRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public void Save();
    }
}

