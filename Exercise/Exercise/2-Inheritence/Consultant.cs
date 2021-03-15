namespace Exercise._2_Inheritence
{
    public class Consultant : Person
    {
        public Consultant(string name,decimal hourlyRate, int hoursReported):base(name)
        {
            HourlyRate = hourlyRate;
            HoursReported = hoursReported;
        }
        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}