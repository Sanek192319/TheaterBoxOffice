using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstraction
{
    public interface IPerfomanceService<T>
    {
        public IEnumerable<Perfomance<T>> GetPerfomanceByAuthor(string AuthorName);
        public IEnumerable<Perfomance<T>> GetPerfomanceByName(string PerfomanceName);
        public IEnumerable<Perfomance<T>> GetPerfomanceByGenre(string GenreName);

        public IEnumerable<Perfomance<T>> GetPerfomanceByDate(DateTime PerfomanceDate);

        public Perfomance<T> GetPerfomanceById(T id);
    }
}
