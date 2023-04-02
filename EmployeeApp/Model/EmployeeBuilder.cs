using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    
    public class EmployeeBuilder
    {
        public string Name { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Date { get; set; } = null;
        public string Salary { get; set; } = null;
        public string Job { get; set; } = null;
        public string JobType { get; set; } = null;

        public EmployeeBuilder() { }

       
        override
        public String ToString()
        {
            return $"{Name}, {LastName}," +
                $" {Date}, {Salary}, {Job}, {JobType}";
        }

        public Employee Build()
        {
            return new Employee(Name, LastName, Date, Salary, Job, JobType);
        }

    }
}
