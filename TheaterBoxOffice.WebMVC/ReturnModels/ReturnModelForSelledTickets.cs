using System;

namespace TheaterBoxOffice.WebMVC.ReturnModels
{
    public class ReturnModelForSelledTickets<T>
    {
        public T Id { get; set; }
        public string PerfomanceName { get; set; }
        public DateTime PerfomanceDate { get; set; }
        public int HallNumber { get; set; }
        public int PlaceNumber { get; set; }
    }
}
