using System;

namespace AmanMicroService.Models
{
    public class Locations
    {
        public int id { get; set;}
        public int? student_id { get; set;}
        public int? request_id { get; set;}
        public string lat { get; set;}
        public string lng { get; set;}
        public string address { get; set;}
        public string start { get; set;}
        public string end { get; set;}
        public Boolean supervisor_is_approved { get; set;}
        public Boolean parent_is_approved { get; set;}
        public DateTime? deleted_at { get; set;}
        public DateTime? created_at { get; set;}
        public DateTime? updated_at { get; set;}
        public int client_id { get; set;}
        public int? route_id { get; set;}
    }
}