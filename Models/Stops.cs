using System;

namespace AmanMicroService.Models
{
    public class Stops
    {
        public int id { get; set; }
        public int ride_id  { get; set; }
        public int  index_order  { get; set; }
        public int scheduler_id  { get; set; }
        public int student_id  { get; set; }
        public int location_id  { get; set; }
        public int request_id  { get; set; }
        public DateTime? estimated_arrival_time  { get; set; }
        public DateTime? actual_arrival_time  { get; set; }
        public DateTime? actual_leave_time  { get; set; }
        public string student_ride_action  { get; set; }
        public DateTime? student_ride_action_time  { get; set; }
        public string absence_status  { get; set; }
        public DateTime? deleted_at  { get; set; }
        public DateTime? created_at  { get; set; }
        public DateTime? updated_at  { get; set; }
        public int client_id  { get; set; }
        public Boolean is_collage  { get; set; }
        public float estimated_arrivel_distance  { get; set; }
        public string ride_type  { get; set; }
        public Boolean? location_violation  { get; set; }
        public Boolean? location_violation_id  { get; set; }
    }
}