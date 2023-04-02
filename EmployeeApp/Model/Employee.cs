using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    [Serializable()]
    public class Employee
    {
        public string Name { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Date { get; set; } = null;
        public string Salary { get; set; } = null;
        public string Job { get; set; } = null;
        public string JobType { get; set; } = null;

        public Employee() { }

       
        override
        public String ToString()
        {
            return $"{Name}, {LastName}," +
                $" {Date}, {Salary}, {Job}, {JobType}";
        }



    }
}
