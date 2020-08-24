using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    class Duck : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Quack, I'm a flying duck");     
        }
    }
    class Airplane : IFlyable, ITakeOff
    {
        public void Fly()
        {
            Console.WriteLine("We're taking off on a plane");
        }
        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }

    class Helicopter : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("hovering in a helicopter");
        }
        public void TakeOff(string destination)
        {
            Console.WriteLine($"Taking off to go to {destination}");
        }
    }
    //public by default, cannot declare any actual behavior for methods, they are just definitions of method signatures
    // classes that use this interface must have this kind of method
    interface IFlyable
    {
        void Fly();
    }

    // also can add IFlyable to the ITakeOff to implement both when ITakeOff is called
    interface ITakeOff : IFlyable
    {
        void TakeOff(string destination);
    }
    
}
