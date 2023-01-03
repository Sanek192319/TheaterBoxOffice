using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Ticket<T>
    {
        public T Id { get; set; }
        public T PerfomanceId { get; set; }
        public T PlaceId { get; set; }
    }
}
