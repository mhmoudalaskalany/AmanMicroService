using System;
using Akka.Actor;
using AmanMicroService.Models;

namespace AmanMicroService.Actors
{
    public class StudentActor : UntypedActor
    {
        public StudentActor(Stops Stops)
        {
            // create StopActor
            /*
                handel events: (send notification from Socket and insert new row in NotificationHistory table )
                1- STUDENT_ENTER
                2- STUDENT_EXIT             => ask StopActor
                3- ST_EXIT_NONE_HOME        => ask StopActor
                4- exit non university      => ask StopActor
                5- ES_F_TIME
                6- NEAR_STUDENT             
                7- ES_ARV_TIME
                8- ES_ARV_DISTANCE
                9- NEAR_HOME
                10- STUDENT_NOT_ATTENDED
             */
        }

        protected override void OnReceive(object message)
        {
            throw new NotImplementedException();
        }
    }
}