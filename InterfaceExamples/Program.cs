using System;
using System.Collections.Generic;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
         

            var duck = new Duck();
            var plane = new Airplane();
            var helicopter = new Helicopter();

            var flyingThings = new List<IFlyable> { duck, plane, helicopter };

            foreach (var thing in flyingThings)
            {
                // check to see if this thing implement this interface
                // if so add it to takeoff so that can be messed with

                if (thing is ITakeOff takeOff)
                {
                    takeOff.TakeOff("Bahamas");
                }
                thing.Fly();
                
            }
        }
    }
}
