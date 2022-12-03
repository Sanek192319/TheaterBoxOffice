using DAL.Entites;
using DAL.Repositories.Abstraction;

namespace DAL.Repositories.Realisation
{
    public class EFHallRepository : EFGenericRepository<HallEntity, int>, IHallRepository
    {
        public EFHallRepository(TheaterBoxOfficeDbContext dbContext) : base(dbContext, dbContext.Halls)
        {

        }
    }
}
