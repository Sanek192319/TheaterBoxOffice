using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Genre<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
