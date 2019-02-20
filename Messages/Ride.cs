namespace AmanMicroService.Messages
{
    public class Ride
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public RideData Data { get; set; }
    }
}