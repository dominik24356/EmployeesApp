using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class MainModel
    {
        private EmployeeBuilder _employeeBuilder;

        public EmployeeBuilder EmployeeBuilder
        {
            set { _employeeBuilder = value; }
            get { return _employeeBuilder; }
        }

        public MainModel()
        {
            _employeeBuilder = new EmployeeBuilder();
        }


    }
}
