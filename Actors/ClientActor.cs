using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    public class ClientActor : UntypedActor
    {
        public ClientActor()
        {
            // if is get message from new ride => create RideActor
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}