using DAL.Entites;
using DAL.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Realisation
{
    public class EFPerfomanceRepository : EFGenericRepository<PerfomanceEntity, int>, IPerfomanceRepository
    {
        public EFPerfomanceRepository(TheaterBoxOfficeDbContext dbContext) : base(dbContext, dbContext.Perfomances)
        {

        }



        IEnumerable<PerfomanceEntity> IPerfomanceRepository.GetPerfomanceByAuthor(string AuthorName)
        {
            var result = _dbContext.Set<PerfomanceEntity>()
                 .Where(perfomance => perfomance.AuthurName == AuthorName).ToList();
            return result;

        }
    }
}
