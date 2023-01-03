namespace DataModel
{
    public class Booking<T>
    {
        public T Id { get; set; }
        public T PerfomanceId { get; set; }
        public T PlaceId { get; set; }
    }
}
