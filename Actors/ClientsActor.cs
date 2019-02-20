using System;
using Akka.Actor;
using AmanMicroService.Models;

namespace AmanMicroService.Actors
{
    public class ClientsActor : UntypedActor
    {
        public ClientsActor()
        {
            // select all clients

            // and foreach => create ClientActor
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}