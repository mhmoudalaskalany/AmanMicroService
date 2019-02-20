using System;

namespace AmanMicroService.Models
{
    public class Stops
    {
        public int Id { get; set; }
        public int RideId  { get; set; }
        public int  IndexOrder  { get; set; }
        public int SchedulerId  { get; set; }
        public int StudentId  { get; set; }
        public int LocationId  { get; set; }
        public int RequestId  { get; set; }
        public DateTime? EstimatedArrivalTime  { get; set; }
        public DateTime? ActualArrivalTime  { get; set; }
        public DateTime? ActualLeaveTime  { get; set; }
        public string StudentRideAction  { get; set; }
        public DateTime? StudentRideActionTime  { get; set; }
        public string AbsenceStatus  { get; set; }
        public DateTime? DeletedAt  { get; set; }
        public DateTime? CreatedAt  { get; set; }
        public DateTime? UpdatedAt  { get; set; }
        public int ClientId  { get; set; }
        public Boolean IsCollage  { get; set; }
        public float EstimatedArrivelDistance  { get; set; }
        public string RideType  { get; set; }
        public Boolean? LocationViolation  { get; set; }
        public Boolean? LocationViolationId  { get; set; }
    }
}