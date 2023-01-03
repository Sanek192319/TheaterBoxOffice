using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstraction
{
    public interface IPlaceService<T>
    {
        public IEnumerable<Place<T>> GetAllAvaliablePlaces(T PerfomanceId, T HallId);

        public Place<T> GetPlaceById(T id);
    }
}
