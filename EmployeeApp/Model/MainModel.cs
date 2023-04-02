using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace EmployeeApp.Model
{
    class MainModel
    {
        private Employee _employee;

        private List<Employee> _employees = new List<Employee>();


        private string xmlLocation = "D:\\Projekty C#\\EmployeeApp\\EmployeeApp\\employeesXML.xml";




        public Employee Employee
        {
            set { _employee = value; }
            get { return _employee; }
        }

        public List<Employee> Employees
        {
            set { _employees = value; }
            get { return _employees; }
        }

        public MainModel()
        {
            _employee = new Employee();
        }


        

        public void SerializeEmployees()
        {
            //create the serialiser to create the xml
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Employee>));

            // Set formatting options
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\n";
            settings.NewLineHandling = NewLineHandling.Replace;

            // Create the TextWriter for the serialiser to use
            TextWriter filestream = new StreamWriter(xmlLocation);

            // Create the XmlWriter to apply the formatting options
            XmlWriter writer = XmlWriter.Create(filestream, settings);

            //write to the file with formatted output
            serialiser.Serialize(writer, _employees);

            // Close the file
            filestream.Close();
        }

        public void DeserializeEmployees()
        {
            List<Employee> emp = new List<Employee>();

            //create the serialiser to read the xml
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Employee>));

            // Create the TextReader for the serialiser to use
            TextReader filestream = new StreamReader(xmlLocation);

            //read the XML data
            emp = (List<Employee>)serialiser.Deserialize(filestream);

            //close the file
            filestream.Close();


            _employees = emp;
        }

        public void addEmployee()
        {
            _employees.Add(_employee);
        }

        







    }
}
