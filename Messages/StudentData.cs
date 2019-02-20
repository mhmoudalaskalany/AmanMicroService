using System;

namespace AmanMicroService.Messages
{
    public class StudentData
    {
        public int id { get; set; }
        public int ride_id { get; set; }
        public int index_order { get; set; }
        public int scheduler_id { get; set; }
        public int student_id { get; set; }
        public int location_id { get; set; }
        public int request_id { get; set; }
        public DateTime estimated_arrival_time { get; set; }
        public DateTime actual_arrival_time { get; set; }
        public string student_ride_action { get; set; }
        public DateTime student_ride_action_time { get; set; }
        public double est_arrival_distane { get; set; }
    }
}