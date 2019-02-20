using System;
using System.Collections.Generic;

namespace AmanMicroService.Messages
{
    public class Signal
    {
        public List<int> StopIds { get; set; }
        public int rideId { get; set; }
        public string shiftType { get; set; }
        public int driverId { get; set; }
        public long messageId { get; set; }
        public int objectId { get; set; }
        public DateTime timeStamp { get; set; }
        public int vectorSpeed { get; set; }
        public DateTime gpsTime { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int clientId { get; set; }
        public int acc { get; set; }
    }
}