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
            var PerfomanceModelEntity = new Perfomance<int>()
            {
                Id = perfomanceDBEntity.Id,
                AuthurName = perfomanceDBEntity.AuthurName,
                HallId = perfomanceDBEntity.HallId,
                PerfomanceName = perfomanceDBEntity.PerfomanceName,
                GenreId = perfomanceDBEntity.GenreId,
                PerfomanceDate = perfomanceDBEntity.PerfomanceDate
            };

            return PerfomanceModelEntity;
        }

        public static PerfomanceEntity ToDbntity(this Perfomance<int> PerfomanceModelEntity)
        {
            var PerfomanceDBEntity = new PerfomanceEntity()
            {
                Id = PerfomanceModelEntity.Id,
                AuthurName = PerfomanceModelEntity.AuthurName,
                HallId = PerfomanceModelEntity.HallId,
                PerfomanceName = PerfomanceModelEntity.PerfomanceName,
                GenreId = PerfomanceModelEntity.GenreId,
                PerfomanceDate = PerfomanceModelEntity.PerfomanceDate
            };

            return PerfomanceDBEntity;
        }
    }
}

