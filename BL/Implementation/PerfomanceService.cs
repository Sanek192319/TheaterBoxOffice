using BL.Abstraction;
using DAL.UnitOfWork.Abstraction;
using DataModel;
using System;
using System.Collections.Generic;
using BL.Mappers;
using System.Linq;

namespace BL.Implementation
{
    class PerfomanceService : IPerfomanceService<int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public PerfomanceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        } 

        public IEnumerable<Perfomance<int>> GetPerfomanceByAuthor(string AuthorName)
        {
            var result = _unitOfWork
                 .PerfomanceRepository
                 .GetPerfomanceByAuthor(AuthorName).Select(perfomance => perfomance.ToModelEntity()).ToList();
            return result;
        }

        public IEnumerable<Perfomance<int>> GetPerfomanceByDate(string PerfomanceDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Perfomance<int>> GetPerfomanceByGenre(string GenreName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Perfomance<int>> GetPerfomanceByName(string PerfomanceName)
        {
            throw new NotImplementedException();
        }
    }
}
