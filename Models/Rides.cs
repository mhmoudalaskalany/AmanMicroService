using System;

namespace AmanMicroService.Models
{
    public class Rides
    {
        public int id { get; set; }
        public int period_department_days_id { get; set; }
        public int driver_id { get; set; }
        public int vehicle_id { get; set; }
        public int date { get; set; }
        public int route_id { get; set; }
        public int week_day_id { get; set; }
        public DateTime? actual_start { get; set; }
        public DateTime? actual_end { get; set; }
        public DateTime? actual_total_travel_time { get; set; }
        public DateTime? estimated_start { get; set; }
        public DateTime? estimated_end { get; set; }
        public DateTime? estimated_total_travel_time { get; set; }
        public string status { get; set; }
        public string reason { get; set; }
        public DateTime? deleted_at { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public int client_id { get; set; }
        public int? estimated_distance { get; set; }
        public string tablet_update_route { get; set; }
        public int polyline_id { get; set; }
        public string ride_type { get; set; }
        public int period_id { get; set; }
        public int? max_speed { get; set; }
        public int? average_speed { get; set; }
        public int? total_duration { get; set; }
        public float? total_distance { get; set; }
    }
}