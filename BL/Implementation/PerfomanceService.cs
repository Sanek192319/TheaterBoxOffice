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

        public IEnumerable<Perfomance<int>> GetPerfomanceByDate(DateTime PerfomanceDate)
        {
            var result = _unitOfWork
               .PerfomanceRepository
               .GetPerfomanceByDate(PerfomanceDate).Select(perfomance => perfomance.ToModelEntity()).ToList();
            return result;
        }

        public IEnumerable<Perfomance<int>> GetPerfomanceByGenre(string GenreName)
        {
            var result = _unitOfWork
                .PerfomanceRepository
                .GetPerfomanceByGenre(GenreName).Select(perfomance => perfomance.ToModelEntity()).ToList();
            return result;
        }

        public Perfomance<int> GetPerfomanceById(int id)
        {
            var result = _unitOfWork
                .PerfomanceRepository
                .GetById(id).ToModelEntity();
            return result;
        }

        public IEnumerable<Perfomance<int>> GetPerfomanceByName(string PerfomanceName)
        {
            var result = _unitOfWork
                .PerfomanceRepository
                .GetPerfomanceByName(PerfomanceName).Select(perfomance => perfomance.ToModelEntity()).ToList();
            return result;
        }
    }
}
