using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3_Polymorphism
{
    public abstract class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started....");
        }
    }
}
