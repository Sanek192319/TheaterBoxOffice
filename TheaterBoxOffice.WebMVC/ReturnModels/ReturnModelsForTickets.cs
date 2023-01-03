namespace TheaterBoxOffice.WebMVC.ReturnModels
{
    public class ReturnModelForTickets<T>
    {
        public T Id { get; set; }
        public float Price { get; set; }
        public T HallId { get; set; }

        public int PlaceNumber { get; set; }

        public T PerfomanceId { get; set; }
    }
}
