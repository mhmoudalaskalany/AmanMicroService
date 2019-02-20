using System;
using System.Collections.Generic;

namespace AmanMicroService.Messages
{
    public class Signal
    {
        public List<int> StopIds { get; set; }
        public int RideId { get; set; }
        public string ShiftType { get; set; }
        public int DriverId { get; set; }
        public long MessageId { get; set; }
        public int ObjectId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int VectorSpeed { get; set; }
        public DateTime GpsTime { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int ClientId { get; set; }
        public int Acc { get; set; }
    }
}