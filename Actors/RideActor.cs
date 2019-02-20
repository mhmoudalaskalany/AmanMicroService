using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    public class RideActor : UntypedActor
    {
        public RideActor()
        {
            // select all Stops
            // ctrate StudentsActor(Stops)
            // create DriverActor
            // create VehicleActor
            
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}