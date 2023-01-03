using DAL.Entites;
using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realisation
{
    public class EFPlaceRepository : EFGenericRepository<PlaceEntity, int>, IPlaceRepository
    {
        public EFPlaceRepository(TheaterBoxOfficeDbContext dbContext) : base(dbContext, dbContext.Places)
        {

        }

        public IEnumerable<PlaceEntity> GetNotBusyPlaces(IEnumerable<int> BusyPlasesId, int HallId)
        {

            var result = _dbContext.Set<PlaceEntity>()
                 .Where(x => !BusyPlasesId.Contains(x.Id) && x.HallId == HallId).ToList();
            return result;
        }
    }
}
