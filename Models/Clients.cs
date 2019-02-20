using System;

namespace AmanMicroService.Models
{
    public class Clients
    {
        public int id {get; set;}
        public string name {get; set;}
        public Boolean is_integration_with_our_system {get; set;}
        public string register_gender_option {get; set;}
        public DateTime? deleted_at {get; set;}
        public DateTime? created_at {get; set;}
        public DateTime? updated_at {get; set;}
    }
}