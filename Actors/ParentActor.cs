using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    public class ParentActor : UntypedActor
    {
        public ParentActor()
        {
            // create ClientsActor and KafkaActor 
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}