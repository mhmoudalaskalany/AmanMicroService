using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    public class ClientActor : UntypedActor
    {
        public ClientActor()
        {
            // if is get message from new ride => create RideActor(message Ride)
            // List of Rides
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}