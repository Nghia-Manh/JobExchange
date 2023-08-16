namespace JobExchange.Models
{
    public class JobInfo
    {
        public int Id { get; set; }
        public Employer Employer { get; set; }
        public TypeJob TypeJob { get; set; }
        public double Salarymin { get; set; }
        public double Salarymax { get; set; }
        public int soluong { get; set; }
        public string Address { get; set; }
        public string Describe { get; set; }
        public DateTime PostTime { get; set;}
        public string Position { get; set; }
    }
}
