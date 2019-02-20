using System;

namespace AmanMicroService.Messages
{
    public class RideData
    {
        public int id { get; set; }
        public int driver_id { get; set; }
        public int vehicle_id { get; set; }
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
        public Double estimated_final_distance { get; set; }
    }
}