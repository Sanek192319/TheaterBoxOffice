using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstraction
{
    public interface IHallService<T>
    {
        public Hall<T> GetHallById(T id);
    }
}
