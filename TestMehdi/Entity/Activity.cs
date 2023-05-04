namespace TestMehdi.Entity
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<DateTime> Traffic { get; set; }
        public Employee Employee { get; set; }

    }
}
