using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public static class PlaceMapper
    {
        public static Place<int> ToModelEntity(this PlaceEntity placeDBEntity)
        {
            var PlaceModelEntity = new Place<int>()
            {
                Id = placeDBEntity.Id,
                price = placeDBEntity.Price,
                HallId = placeDBEntity.HallId,
                PlaceNumber = placeDBEntity.PlaceNumber,   
            };

            return PlaceModelEntity;
        }

        public static PlaceEntity ToDbntity(this Place<int> PlaceModelEntity)
        {
            var PlaceDBEntity = new PlaceEntity()
            {
               Id=PlaceModelEntity.Id,
               Price =  PlaceModelEntity.price,
               HallId = PlaceModelEntity.HallId,
               PlaceNumber=PlaceModelEntity.PlaceNumber,

            };

            return PlaceDBEntity;
        }
    }
}
