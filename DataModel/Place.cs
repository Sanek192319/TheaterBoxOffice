using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Place<T>
    {
        public T Id { get; set; }
        public float price  { get; set; }
        public T HallId     { get; set; }
    }
}
