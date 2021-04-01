using System;

namespace AutoPractice7.CSV.Models
{
    public class EmployeeDto : IDto<EmployeeDto>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public EmployeeDto GetData(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Id = Convert.ToInt32(values[0]);
            FirstName = values[1];
            LastName = values[2];
            DateOfBirth = DateTime.Parse(values[3]);
            Age = Convert.ToInt32(values[4]);
            Salary = Convert.ToDouble(values[5]);
            return this;
        }
    }
}
