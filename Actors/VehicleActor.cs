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
            /*
              handel events: 
                1- NEAR_HOME
                2- STUDENT_NOT_ATTENDED
             */
        }

        public Signal GetLastSignal()
        {
            return LastSignal;
        }
    }
}