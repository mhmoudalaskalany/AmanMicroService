using System;

namespace AmanMicroService.Models
{
    public class Students
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string image { get; set; }
        public string  gender { get; set; }
        public int college_code { get; set; }
        public int college_id { get; set; }
        public string degreetitlar { get; set; }
        public string  st_degree { get; set; }
        public string  address { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string national_id { get; set; }
        public int department_id { get; set; }
        public int building_id { get; set; }
        public int?  vehicle_id { get; set; } 
        public string request_status { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public Boolean is_foreigner { get; set; }
        public Boolean send_notification { get; set; }
        public Boolean arrival_notification { get; set; }
        public Boolean ride_notification { get; set; }
        public Boolean driver_notification { get; set; }
        public Boolean driver_call { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
        public DateTime created_at { get; set; }
        public int client_id { get; set; }
        public string RFID { get; set; }
        public string name { get; set; }
        public int? parent_national_id { get; set; }
        public string email { get; set; }
        public int location_id { get; set; }
        public string phone  { get; set; }
        public string house_number { get; set; }
    }
}