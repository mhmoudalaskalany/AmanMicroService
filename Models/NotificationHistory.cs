using System;

namespace AmanMicroService.Models
{
    public class NotificationHistory
    {
        public int id { get; set; }
        public int student_id { get; set; }
        public int dateTime { get; set; }
        public string action_type { get; set; }
        public string icon { get; set; }
        public string notification_text { get; set; }
        public Boolean student_is_read { get; set; }
        public DateTime? deleted_at { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int client_id { get; set; }
        public int driver_id { get; set; }
        public int ride_id { get; set; }
    }
}