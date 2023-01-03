using DAL.Entites;
using System;
using System.Collections.Generic;

namespace DAL.Repositories.Abstraction
{
    public interface IPerfomanceRepository : IRepository<PerfomanceEntity, int>
    {
        public IEnumerable<PerfomanceEntity> GetPerfomanceByAuthor(string AuthorName);
        public IEnumerable<PerfomanceEntity> GetPerfomanceByName(string PerfomanceName);
        public IEnumerable<PerfomanceEntity> GetPerfomanceByGenre(string GenreName);

        public IEnumerable<PerfomanceEntity> GetPerfomanceByDate(DateTime PerfomanceDate);
    }
}
