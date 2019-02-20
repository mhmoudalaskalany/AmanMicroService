using System;

namespace AmanMicroService.Models
{
    public class NotificationHistory
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DateTime { get; set; }
        public string ActionType { get; set; }
        public string Icon { get; set; }
        public string NotificationText { get; set; }
        public Boolean StudentIsRead { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ClientId { get; set; }
        public int DriverId { get; set; }
        public int RideId { get; set; }
    }
}