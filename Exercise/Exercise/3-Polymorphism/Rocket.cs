using System;

namespace Exercise._3_Polymorphism
{
    public class Rocket : Vehicle
    {
        public override void Start()
        {
            //Console.Write("Rocket starts in :\n");
            for (int a = 3; a >= 0; a--)
            {
                Console.Write("\r{0}", a);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("\nBOOOOMMMMMM!!!!");
            base.Start();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
} 