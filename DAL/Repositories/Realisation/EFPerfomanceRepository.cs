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

        public IEnumerable<PerfomanceEntity> GetPerfomanceByDate(DateTime PerfomanceDate)
        {
            var result = _dbContext.Set<PerfomanceEntity>()
                .Where(perfomance => perfomance.PerfomanceDate == PerfomanceDate).ToList();
            return result;
        }

        public IEnumerable<PerfomanceEntity> GetPerfomanceByGenre(string GenreName)
        {
            var result = _dbContext.Set<PerfomanceEntity>()
                 .Where(perfomance => perfomance.Genre.GenreName == GenreName).ToList();
            return result;
        }

        IEnumerable<PerfomanceEntity> IPerfomanceRepository.GetPerfomanceByAuthor(string AuthorName)
        {
            var result = _dbContext.Set<PerfomanceEntity>()
                 .Where(perfomance => perfomance.AuthurName == AuthorName).ToList();
            return result;

        }

        IEnumerable<PerfomanceEntity> IPerfomanceRepository.GetPerfomanceByName(string PerfomanceName)
        {
            var result = _dbContext.Set<PerfomanceEntity>()
                 .Where(perfomance => perfomance.PerfomanceName == PerfomanceName).ToList();
            return result;

        }
    }
}
