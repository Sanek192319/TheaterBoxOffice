using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class TicketEntity : BaseEntity<int>    
    {
        public int PerfomanceId { get; set; }
        public int PlaceId { get; set; }
        public PlaceEntity Place { get; set; }

        //public int UserId { get; set; }
        //public UserEntity User { get; set; }
    }
}
