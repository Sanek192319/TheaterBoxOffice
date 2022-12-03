using DAL.Entites;
using System.Collections.Generic;

namespace DAL.Repositories.Abstraction
{
    public interface IPerfomanceRepository : IRepository<PerfomanceEntity, int>
    {
        public IEnumerable<PerfomanceEntity> GetPerfomanceByAuthor(string AuthorName);
    }
}
