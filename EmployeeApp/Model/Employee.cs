using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Date { get; set; }
        public string Salary { get; set; }
        public string Job { get; set; }
        public string JobType { get; set; }

        public Employee()
        {
            Name = "";
            LastName = "";
            Date = "";
            Salary = "";
            Job = "";
            JobType = "";
        }

        public Employee(string name, string lastName, string date, string salary, string job, string jobType)
        {
            Name = name;
            LastName = lastName;
            Date = date;
            Salary = salary;
            Job = job;
            JobType = jobType;
        }

        public String ToString()
        {
            return $"{Name}, {LastName}," +
                $" {Date}, {Salary}, {Job}, {JobType}";
        }
    }
}
