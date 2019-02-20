using System;

namespace AmanMicroService.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string  Gender { get; set; }
        public int CollegeCode { get; set; }
        public int CollegeId { get; set; }
        public string Degreetitlar { get; set; }
        public string  StDegree { get; set; }
        public string  Address { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string NationalId { get; set; }
        public int DepartmentId { get; set; }
        public int BuildingId { get; set; }
        public int?  VehicleId { get; set; } 
        public string RequestStatus { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public Boolean IsForeigner { get; set; }
        public Boolean SendNotification { get; set; }
        public Boolean ArrivalNotification { get; set; }
        public Boolean RideNotification { get; set; }
        public Boolean DriverNotification { get; set; }
        public Boolean DriverCall { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ClientId { get; set; }
        public string Rfid { get; set; }
        public string Name { get; set; }
        public int? ParentNationalId { get; set; }
        public string Email { get; set; }
        public int LocationId { get; set; }
        public string Phone  { get; set; }
        public string HouseNumber { get; set; }
    }
}