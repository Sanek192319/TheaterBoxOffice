using Microsoft.AspNetCore.Mvc;
using System;

namespace TheaterBoxOffice.WebMVC.ReturnModels
{
    public class ReturnModelForBookings<T> 
    {
        public T Id { get; set; }
        public T PerfomanceId { get; set; }
        public T PlaceId { get; set; }
        public string PerfomanceName { get; set; }
        public DateTime PerfomanceDate { get; set; }
        public int HallNumber { get; set; }
        public int PlaceNumber { get; set; }

    }
}
