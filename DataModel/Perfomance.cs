using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Perfomance<T>
    {
        public T Id { get; set; }
        public T HallId { get; set; }
        public string PerfomanvName { get; set; }
        public T GenreId    { get; set; }
    }
}
