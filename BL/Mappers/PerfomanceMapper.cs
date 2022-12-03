using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public static class PerfomanceMapper
    {
        public static Perfomance<int> ToModelEntity(this PerfomanceEntity perfomanceDBEntity)
        {
            var dishTypeModelEntity = new Perfomance<int>()
            {
                Id = perfomanceDBEntity.Id,
                AuthurName = perfomanceDBEntity.AuthurName,
                HallId = perfomanceDBEntity.HallId,
                PerfomanceName = perfomanceDBEntity.PerfomanceName,
                GenreId = perfomanceDBEntity.GenreId
            };

            return dishTypeModelEntity;
        }

        public static PerfomanceEntity ToDbntity(this Perfomance<int> dishTypeModelEntity)
        {
            var basketDbEntity = new PerfomanceEntity()
            {
                Id = dishTypeModelEntity.Id,
                AuthurName = dishTypeModelEntity.AuthurName,
                HallId = dishTypeModelEntity.HallId,
                PerfomanceName = dishTypeModelEntity.PerfomanceName,
                GenreId = dishTypeModelEntity.GenreId
            };

            return basketDbEntity;
        }
    }
}

