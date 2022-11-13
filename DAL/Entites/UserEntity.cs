using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class UserEntity : BaseEntity<int>
    {
        public int TicketId { get; set; }   
        public TicketEntity Ticket { get; set; }
    }
}
