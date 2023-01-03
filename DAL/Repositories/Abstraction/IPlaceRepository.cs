using DAL.Entites;
using System.Collections.Generic;

namespace DAL.Repositories.Abstraction
{
    public interface IPlaceRepository : IRepository<PlaceEntity, int>
    {
        public IEnumerable<PlaceEntity> GetNotBusyPlaces(IEnumerable<int> BusyPlasesId, int HallId);

    }
}
