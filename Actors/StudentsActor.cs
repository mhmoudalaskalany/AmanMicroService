using System;
using Akka.Actor;
using AmanMicroService.Models;

namespace AmanMicroService.Actors
{
    public class StudentsActor : UntypedActor
    {

        public StudentsActor(Stops Stops)
        {
            // handel Stops data
            // create List of Students (ids)
            // create StudentActor(Stops) => two Stops per student 
            /*
                handel events:
                1- START_RIDE
                2- END_RIDE
                3- ALARM_ROUTE_STOP 
                4- missing delivery student => DriverActor
                5- NEAR_DESTINATION
                6- ES_F_DISTANCE
                7- DELAY_ALARM
             */
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}