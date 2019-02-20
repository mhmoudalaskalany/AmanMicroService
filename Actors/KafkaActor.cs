using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    public class KafkaActor : UntypedActor
    {
        public KafkaActor()
        {
            //
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}