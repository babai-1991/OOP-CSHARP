using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._3_Polymorphism
{
    public abstract class Person
    {
        protected Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public abstract void GetPaid();

    }
}
