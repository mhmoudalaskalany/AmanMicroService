using System;
using Akka.Actor;

namespace AmanMicroService.Actors
{
    /*
        send notification to driver
    */
    public class DriverActor : UntypedActor
    {
        public DriverActor()
        {
            //
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}