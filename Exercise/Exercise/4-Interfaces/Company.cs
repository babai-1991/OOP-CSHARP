using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4_Interfaces
{
    public class Company:IPayable
    {
        public void GetPaid()
        {
            Console.WriteLine("Paying invoice");
        }
    }
}
