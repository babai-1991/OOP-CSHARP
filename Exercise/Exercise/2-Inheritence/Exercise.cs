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
            //Company acme = new Company()
            //{
            //    Name = "ACME Corp",
            //    Employees = new List<Employee>()
            //    {
            //        new Employee("Babai", Department.Programming),
            //        new Employee("Tatai", Department.Tester),
            //        new Employee("Papai", Department.Marketing),
            //        new Employee("Jon", Department.Management),
            //        new Employee("Sara", Department.Programming)
            //    },
            //    Consultants = new List<Consultant>()
            //    {
            //        new Consultant("Jon Skeet",30.22m,23),
            //        new Consultant("Alex Allen",329.28m,12),
            //        new Consultant("John Papa",51.21m,8)
            //    }
            //};

            Company acme = new Company {Name = "ACME Corp"};
            acme.Employees.Add(new Employee("John",Department.Programming));
            acme.Employees.Add(new Employee("Babai", Department.Programming));
            acme.Employees.Add(new Employee("Papai", Department.Marketing));

            acme.Consultants.Add(new Consultant("Jon Skeet", 30.22m, 23));
            acme.Consultants.Add(new Consultant("Alex Allen", 329.28m, 12));
            
            Display(acme);
        }

        private static void Display(Company company)
        {
            Console.WriteLine("Employee");

            foreach (var employee in company.Employees)
            {
                Console.WriteLine($"Name {employee.Name} Department {employee.Dept}");
            }

            Console.WriteLine("Consultants");

            foreach (var consultant in company.Consultants)
            {
                Console.WriteLine($"Name {consultant.Name} and hourlyrate {consultant.HourlyRate} total work {consultant.HoursReported}. Total {consultant.HourlyRate*consultant.HoursReported}");
            }
        }
    }
}
