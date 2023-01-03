using DAL.Entites;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mappers
{
    public static class TicketMapper
    {
        public static Ticket<int> ToModelEntity(this TicketEntity ticketDBEntity)
        {
            var TicketModelEntity = new Ticket<int>()
            {
                Id = ticketDBEntity.Id,
                PerfomanceId = ticketDBEntity.PerfomanceId,
                PlaceId = ticketDBEntity.PlaceId
            };

            return TicketModelEntity;
        }

        public static TicketEntity ToDbntity(this Ticket<int> TicketModelEntity)
        {
            var TicketDBEntity = new TicketEntity()
            {
                Id = TicketModelEntity.Id,
                PerfomanceId = TicketModelEntity.PerfomanceId,
                PlaceId = TicketModelEntity.PlaceId

            };

            return TicketDBEntity;
        }
    }

}