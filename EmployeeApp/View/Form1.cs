using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp.View
{
    public partial class Form1 : Form
    {

        public event Action<String> getDob;
        public event Action<int> getSalary;
        public event Action<String> getJob;
        public event Action<String> getJobType;
        public event Action saveEmployee;
        public event Action loadEmployee;
        public event Action addEmployee;
        public event Action<String> getName;
        public event Action<String> getLastName;


        public Form1()
        {
            InitializeComponent();
        }

        private void get_DoB(object sender, EventArgs e)
        {
            
            getDob?.Invoke();
        }

        private void get_salary(object sender, EventArgs e)
        {
            getSalary?.Invoke();
        }

        private void get_job(object sender, EventArgs e)
        {
            getJob?.Invoke();
        }

        private void get_jobType(object sender, EventArgs e)
        {
            getJob?.Invoke();
        }

        private void save(object sender, EventArgs e)
        {
            saveEmployee?.Invoke();
        }

        private void load(object sender, EventArgs e)
        {
            loadEmployee?.Invoke();
        }

        private void add(object sender, EventArgs e)
        {
            addEmployee?.Invoke();
        }

        private void get_Imie(object sender, EventArgs e)
        {
            getName?.Invoke(lastNameBox.Text);
        }

        private void get_Nazwisko(object sender, EventArgs e)
        {
            getLastName?.Invoke(nameBox.Text); 
        }

        
    }
}
