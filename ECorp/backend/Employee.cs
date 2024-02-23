

namespace ECorp.backend
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Worksite { get; set; }
        public decimal HourlyWage { get; set; } = 0;
        public decimal Salary { get; set; } = 0;
        
        public Employee(int id = 0, string first_name = "", string last_name = "", DateTime birth_date= default(DateTime), string worksite = "", decimal hourly = 0, decimal salary = 0) {
            Id = id;
            FirstName = first_name; 
            LastName = last_name;
            BirthDate = birth_date; 
            Worksite = worksite;
            HourlyWage = hourly;
            Salary = salary;    

        }
    }
}
