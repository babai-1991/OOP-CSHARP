using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._4_Interfaces
{
    class Exercise
    {
        public static void Start()
        {
            Pay(new Employee());
            Pay(new Company());
        }

        static void Pay(IPayable payable)
        {
            payable.GetPaid();
        }
    }
}
