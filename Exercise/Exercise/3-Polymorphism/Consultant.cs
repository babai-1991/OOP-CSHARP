using System;

namespace Exercise._3_Polymorphism
{
    class Consultant:Person
    {
        public Consultant(string name, int hoursReported) : base(name)
        {
            HoursReported = hoursReported;
        }
        public int HoursReported { get; set; }
        public override void GetPaid()
        {
            Console.WriteLine($"The Consultant {Name} => paid for {HoursReported}");

        }
    }
}