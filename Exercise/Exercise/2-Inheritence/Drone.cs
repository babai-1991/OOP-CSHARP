namespace Exercise._2_Inheritence
{
    public class Drone :Bee
    {
        public Drone(string name, double honeyCollection) : base(name)
        {
            HoneyCollection = honeyCollection;
        }
        public double HoneyCollection { get; set; }
    }
}