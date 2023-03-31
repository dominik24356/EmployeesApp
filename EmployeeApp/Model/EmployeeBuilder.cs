using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class EmployeeBuilder
    {
        public string Name { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Date { get; set; } = null;
        public string Salary { get; set; } = null;
        public string Job { get; set; } = null;
        public string JobType { get; set; } = null;

        public EmployeeBuilder() { }

       

        public String EmployeeAsText()
        {
            return $"{Name}, {LastName}," +
                $" {Date}, {Salary}, {Job}, {JobType}";
        }



    }
}
