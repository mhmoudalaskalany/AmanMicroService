using System;
using Akka.Actor;
using AmanMicroService.Models;

namespace AmanMicroService.Actors
{
    public class StopActor : UntypedActor
    {
        public StopActor()
        {
            /*
                handel events: (update stop row in Stops table)
                1- STUDENT_ENTER
                2- STUDENT_EXIT
                3- ST_EXIT_NONE_HOME
                4- exit non university
                5- ES_F_TIME
                6- NEAR_STUDENT
                7- ES_ARV_TIME
                8- ES_ARV_DISTANCE
                9- STUDENT_NOT_ATTENDED
             */
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}