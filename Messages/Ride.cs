namespace AmanMicroService.Messages
{
    public class Ride
    {
        public int id { get; set; }
        public string @event { get; set; }
        public RideData data { get; set; }
    }
}