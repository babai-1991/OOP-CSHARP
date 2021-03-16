using System;

namespace Exercise._3_Polymorphism
{
    class Employee:Person
    {
        public Employee(string name) : base(name)
        {
        }

        public override void GetPaid()
        {
            Console.WriteLine($"The employee {Name} => salary paid");
        }
    }
}