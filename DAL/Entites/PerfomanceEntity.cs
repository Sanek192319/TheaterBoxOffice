using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class PerfomanceEntity : BaseEntity<int>
    {
        public string AuthurName { get; set; }
        public int GenreId { get; set; }
        public GenreEntity Genre { get; set; }
        public string PerfomanceName { get; set; }
        public int HallId { get; set; }
        public HallEntity Hall { get; set; }

        public DateTime PerfomanceDate { get; set; }
        
    }
}
