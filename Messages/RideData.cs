using System;

namespace AmanMicroService.Messages
{
    public class RideData
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public int RouteId { get; set; }
        public int WeekDayId { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public DateTime? ActualTotalTravelTime { get; set; }
        public DateTime? EstimatedStart { get; set; }
        public DateTime? EstimatedEnd { get; set; }
        public DateTime? EstimatedTotalTravelTime { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public Double EstimatedFinalDistance { get; set; }
    }
}