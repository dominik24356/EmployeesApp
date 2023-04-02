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


        public Form1()
        {
            InitializeComponent();
        }


        public event Action<String> getDob;
        public event Action<String> getSalary;
        public event Action<String> getJob;
        public event Action<String> getJobType;
        public event Action saveEmployee;
        public event Action loadEmployee;
        public event Action addEmployee;
        public event Action<String> getName;
        public event Action<String> getLastName;
        public event Action<int> selectedEmployee;


        public TextBox GetNameBox()
        {
            return nameBox;
        }

        public TextBox GetLastNameBox()
        {
            return lastNameBox;
        }

        public DateTimePicker GetDateBox()
        {
            return dateBox;
        }

        public NumericUpDown GetSalaryBox()
        {
            return salaryBox;
        }

        public ComboBox GetJobBox()
        {
            return jobBox;
        }

        public RadioButton GetJobTypeBox1()
        {
            return jobTypeBox1;
        }

        public RadioButton GetJobTypeBox2()
        {
            return jobTypeBox2;
        }

        public RadioButton GetJobTypeBox3()
        {
            return jobTypeBox3;
        }

        public ListBox GetListBox()
        {
            return listBox1;
        }

        public void ClearErrorProviderForField(Control field)
        {
            errorProvider1.SetError(field, ""); // ustawienie pustego komunikatu błędu usuwa ErrorProvider
        }

        public void SetErrorProviderOnField(string errorMessage, Control control)
        {
            errorProvider1.SetError(control, errorMessage);
        }



        private void get_DoB(object sender, EventArgs e)
        {
            getDob?.Invoke(dateBox.Text);
        }

        private void get_salary(object sender, EventArgs e)
        {
            getSalary?.Invoke(salaryBox.Value.ToString());
        }

        private void get_job(object sender, EventArgs e)
        {
            getJob?.Invoke(jobBox.Text);
        }

        private void get_jobType(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            getJobType?.Invoke(radioButton.Text);
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
            getName?.Invoke(nameBox.Text);
        }

        private void get_Nazwisko(object sender, EventArgs e)
        {
            getLastName?.Invoke(lastNameBox.Text);
            
        }

        private void selected_employee(object sender, EventArgs e)
        {
            var obj = sender as ListBox;
            selectedEmployee?.Invoke(obj.SelectedIndex);
        }
    }
}
