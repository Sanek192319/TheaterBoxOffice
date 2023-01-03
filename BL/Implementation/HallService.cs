using BL.Abstraction;
using BL.Mappers;
using DAL.UnitOfWork.Abstraction;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
     class HallService : IHallService<int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public HallService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Hall<int> GetHallById(int id)
        {
            var result = _unitOfWork
              .HallRepository
              .GetById(id).ToModelEntity();
            return result;
        }
    }
}
