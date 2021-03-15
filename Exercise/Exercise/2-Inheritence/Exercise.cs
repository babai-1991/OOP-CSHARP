using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2_Inheritence
{
    class Exercise
    {
        public static void Start()
        {
            Hive beehive = new Hive(new Queen("QueenBee"));
            beehive.Drones.Add(new Drone("Buzzy",1.67d));
            beehive.Drones.Add(new Drone("Fizzy",1.25d));
            beehive.Drones.Add(new Drone("Matt",1.87d));

            Console.WriteLine(beehive.Queen.Name);
            foreach (var drone in beehive.Drones)
            {
                Console.WriteLine($"Name is {drone.Name} and collected honey {drone.HoneyCollection}");
            }
        }
    }
}
