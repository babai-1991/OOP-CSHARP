using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2_Inheritence
{
    public class Bee
    {
        public Bee(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }

    public class Hive
    {
        public Hive(Queen queen)
        {
            Queen = queen;
           Drones = new List<Drone>();
        }
        public Queen Queen { get; set; }
        public List<Drone> Drones { get; set; }
    }
}
