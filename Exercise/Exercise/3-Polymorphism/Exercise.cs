using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3_Polymorphism
{
    public static class Exercise
    {
        public static void Start()
        {
            //List<Vehicle> vehicles = new List<Vehicle>();
            //vehicles.Add(new Boat());
            //vehicles.Add(new Car());
            //vehicles.Add(new Rocket());

            //foreach (var vehicle in vehicles)
            //{
            //    vehicle.Start();
            //    vehicle.Stop();
            //    Console.WriteLine();
            //}


            Employee employee = new Employee("Babai");
            Pay(employee);
            Consultant consultant = new Consultant("John",21);
            Pay(consultant);
        }

        static void Pay(Person person)
        {
            person.GetPaid();
        }
    }
}
