using System;

namespace AmanMicroService.Models
{
    public class Clients
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public Boolean IsIntegrationWithOurSystem {get; set;}
        public string RegisterGenderOption {get; set;}
        public DateTime? DeletedAt {get; set;}
        public DateTime? CreatedAt {get; set;}
        public DateTime? UpdatedAt {get; set;}
    }
}