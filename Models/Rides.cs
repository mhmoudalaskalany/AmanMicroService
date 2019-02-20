using System;

namespace AmanMicroService.Models
{
    public class Rides
    {
        public int Id { get; set; }
        public int PeriodDepartmentDaysId { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public int Date { get; set; }
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
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ClientId { get; set; }
        public int? EstimatedDistance { get; set; }
        public string TabletUpdateRoute { get; set; }
        public int PolylineId { get; set; }
        public string RideType { get; set; }
        public int PeriodId { get; set; }
        public int? MaxSpeed { get; set; }
        public int? AverageSpeed { get; set; }
        public int? TotalDuration { get; set; }
        public float? TotalDistance { get; set; }
    }
}