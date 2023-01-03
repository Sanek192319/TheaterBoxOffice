using DAL.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheaterBoxOfficeDbContext : DbContext
    {
        #region ctrs

        public TheaterBoxOfficeDbContext() : base("TheaterBoxOfficeDb")
        {
            Database.CreateIfNotExists();
        }

        #endregion ctrs

        #region members

        public virtual DbSet<BookingEntity> Bookings { get; set; }
        public virtual DbSet<GenreEntity> Genres { get; set; }
        public virtual DbSet<HallEntity> Halls { get; set; }
        public virtual DbSet<PerfomanceEntity> Perfomances { get; set; }
        public virtual DbSet<PlaceEntity> Places { get; set; }
        public virtual DbSet<TicketEntity> Tickets { get; set; }

        #endregion members
    }
}
