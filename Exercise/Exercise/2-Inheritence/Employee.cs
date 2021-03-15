namespace Exercise._2_Inheritence
{
    public class Employee:Person
    {
        public Employee(string name, Department department) :base(name)
        {
            Dept = department;
        }
        public Department Dept { get; set; }
    }
}