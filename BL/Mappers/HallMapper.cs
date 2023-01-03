using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public static class HallMapper
    {
        public static Hall<int> ToModelEntity(this HallEntity hallDBEntity)
        {
            var HallModelEntity = new Hall<int>()
            {
                Id = hallDBEntity.Id,
                HallNumber = hallDBEntity.Number
            };

            return HallModelEntity;
        }

        public static HallEntity ToDbntity(this Hall<int> HallModelEntity)
        {
            var HallDBEntity = new HallEntity()
            {
                Id = HallModelEntity.Id,
                Number = HallModelEntity.HallNumber

            };

            return HallDBEntity;
        }
    }
}

