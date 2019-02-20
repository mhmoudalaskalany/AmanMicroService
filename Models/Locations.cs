using System;

namespace AmanMicroService.Models
{
    public class Locations
    {
        public int Id { get; set;}
        public int? StudentId { get; set;}
        public int? RequestId { get; set;}
        public string Lat { get; set;}
        public string Lng { get; set;}
        public string Address { get; set;}
        public string Start { get; set;}
        public string End { get; set;}
        public Boolean SupervisorIsApproved { get; set;}
        public Boolean ParentIsApproved { get; set;}
        public DateTime? DeletedAt { get; set;}
        public DateTime? CreatedAt { get; set;}
        public DateTime? UpdatedAt { get; set;}
        public int ClientId { get; set;}
        public int? RouteId { get; set;}
    }
}