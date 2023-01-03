using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public static class BookingMapper
    {
        public static Booking<int> ToModelEntity(this BookingEntity bookingDBEntity)
        {
            var BookingModelEntity = new Booking<int>()
            {
                Id = bookingDBEntity.Id,
                PerfomanceId = bookingDBEntity.PerfomanceId,
                PlaceId = bookingDBEntity.PlaceId
            };

            return BookingModelEntity;
        }

        public static BookingEntity ToDbntity(this Booking<int> BookingModelEntity)
        {
            var BookingDBEntity = new BookingEntity()
            {
                Id = BookingModelEntity.Id,
                PerfomanceId = BookingModelEntity.PerfomanceId,
                PlaceId = BookingModelEntity.PlaceId

            };

            return BookingDBEntity;
        }
    }
}

