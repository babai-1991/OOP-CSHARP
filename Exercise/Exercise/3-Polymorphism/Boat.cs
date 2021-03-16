using System;

namespace Exercise._3_Polymorphism
{
    public class Boat:Vehicle
    {
        public override string ToString()
        {
            return "Boat12";
        }

        //have to implement abstract member
        public override void Stop()
        {
            Console.WriteLine("Docking boat");
        }
    }
    
}