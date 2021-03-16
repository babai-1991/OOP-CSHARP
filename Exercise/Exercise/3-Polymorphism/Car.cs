using System;

namespace Exercise._3_Polymorphism
{
    public class Car:Vehicle
    {
        public override string ToString()
        {
            return "Car";
        }

        //have to implement abstract member
        public override void Stop()
        {
            Console.WriteLine("Parking Car");
        }
    }
    
}