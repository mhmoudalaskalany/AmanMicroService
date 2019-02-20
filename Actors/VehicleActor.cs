using System;
using Akka.Actor;
using AmanMicroService.Messages;

namespace AmanMicroService.Actors
{
    /*
        handel LOCATION_CHANGE event
     */
    public class VehicleActor : UntypedActor
    {
        public Signal LastSignal ;

        public VehicleActor()
        {

        }

        protected override void OnReceive(object message)
        {
            // receive Signal
            // set Signal in LastSignal
        }

        public Signal getLastSignal()
        {
            return LastSignal;
        }
    }
}