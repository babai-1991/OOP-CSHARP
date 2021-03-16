using System;

namespace Exercise._4_Interfaces
{
    public class Employee:Person,IPayable
    {
        public void GetPaid()
        {
            Console.WriteLine("Paying salary");
        }
    }
}