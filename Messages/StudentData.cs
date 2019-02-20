using System;

namespace AmanMicroService.Messages
{
    public class StudentData
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public int IndexOrder { get; set; }
        public int SchedulerId { get; set; }
        public int StudentId { get; set; }
        public int LocationId { get; set; }
        public int RequestId { get; set; }
        public DateTime EstimatedArrivalTime { get; set; }
        public DateTime ActualArrivalTime { get; set; }
        public string StudentRideAction { get; set; }
        public DateTime StudentRideActionTime { get; set; }
        public double EstArrivalDistane { get; set; }
    }
}