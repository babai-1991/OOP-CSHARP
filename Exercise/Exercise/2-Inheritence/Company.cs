using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2_Inheritence
{
    class Company
    {
        public Company()
        {
           Employees = new List<Employee>();
            Consultants = new List<Consultant>();
        }
        public string Name  { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Consultant> Consultants { get; set; }
    }
}
