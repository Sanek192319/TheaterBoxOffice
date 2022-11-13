using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entites
{
    public class PlaceEntity : BaseEntity<int>
    {
        public float Price { get; set; }
        public int HallId { get; set; }
        public HallEntity Hall { get; set; }
    }
}
