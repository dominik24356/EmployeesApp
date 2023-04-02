using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;
        // some other fields
        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            // constructor stuff
            _view = view;
            _model = model;

            _view.addEmployee += _view_addEmployee;
            _view.getDob += _view_getDob;
            _view.getSalary += _view_getSalary;
            _view.getJob += _view_getJob;
            _view.getJobType += _view_getJobType;
            _view.saveEmployee += _view_saveEmployee;
            _view.loadEmployee += _view_loadEmployee;
            _view.getName += _view_getName;
            _view.getLastName += _view_getLastName;
            _view.selectedEmployee += _view_selectedEmployee;

        }

        private void _view_selectedEmployee(int index)
        {
            Model.Employee selectedEmp = _model.Employees.ElementAt(index);
            _view.GetNameBox().Text = selectedEmp.Name;
            _view.GetLastNameBox().Text = selectedEmp.LastName;
            _view.GetDateBox().Text = selectedEmp.Date;
            _view.GetSalaryBox().Text = selectedEmp.Salary;
            _view.GetJobBox().Text = selectedEmp.Job;

            String selectedRadioBoxText = selectedEmp.JobType;

            if (selectedRadioBoxText.Equals(_view.GetJobTypeBox1().Text))
            {
                _view.GetJobTypeBox1().Checked = true;
            } else if (selectedRadioBoxText.Equals(_view.GetJobTypeBox2().Text))
            {
                _view.GetJobTypeBox2().Checked = true;
            } else
            {
                _view.GetJobTypeBox3().Checked = true;
            }
            
            

        }

        private void _view_getLastName(string lastName)
        {
            _model.EmployeeBuilder.LastName = lastName;
            if (string.IsNullOrEmpty(lastName))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetLastNameBox());
            }
            else
            {
                _view.ClearErrorProviderForField(_view.GetLastNameBox());
            }

        }

        private void _view_getName(string name)
        {
            _model.EmployeeBuilder.Name = name;
            if (string.IsNullOrEmpty(name))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetNameBox());
                
            }
            else
            {
                _view.ClearErrorProviderForField(_view.GetNameBox());
            }
        }

        private void _view_getJobType(string jobType)
        {
            _model.EmployeeBuilder.JobType = jobType;
        }

        private void _view_getJob(string job)
        {
            _model.EmployeeBuilder.Job = job;

            if (string.IsNullOrEmpty(job))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetJobBox());
            }
            else
            {
                _view.ClearErrorProviderForField(_view.GetJobBox());
            }

        }

        private void _view_getSalary(string salary)
        {

            _model.EmployeeBuilder.Salary = salary;

            if (string.IsNullOrEmpty(salary))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetSalaryBox());
            }
            else
            {
                _view.ClearErrorProviderForField(_view.GetSalaryBox());

                
            }
        }

        private void _view_getDob(string date)
        {

            _model.EmployeeBuilder.Date = date;

            if (string.IsNullOrEmpty(date))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetDateBox());
            }
            else
            {
                _view.ClearErrorProviderForField(_view.GetDateBox());

            }
        }


        private void _view_addEmployee()
        {
            bool isError = false;
            if (String.IsNullOrEmpty(_model.EmployeeBuilder.Name) || _model.EmployeeBuilder.Name.Equals(""))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetNameBox());
                isError = true;

            }

            if (String.IsNullOrEmpty(_model.EmployeeBuilder.LastName))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetLastNameBox());
                isError = true;
            }

            if (String.IsNullOrEmpty(_model.EmployeeBuilder.Date))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetDateBox());
                isError = true;
            }

            if (_model.EmployeeBuilder.Salary is null || _model.EmployeeBuilder.Salary.Equals("0"))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetSalaryBox());
                isError = true;
            }

            if (String.IsNullOrEmpty(_model.EmployeeBuilder.Job))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetJobBox());
                isError = true;
            }

            if (String.IsNullOrEmpty(_model.EmployeeBuilder.JobType))
            {
                _view.SetErrorProviderOnField("Pole nie może być puste !", _view.GetJobTypeBox1());
                isError = true;
            }



            if (!isError)
            {
                _view.GetListBox().Items.Add(_model.EmployeeBuilder.ToString());
                _model.addEmployee();
                
            }
        }

        private void _view_loadEmployee()
        {
            _model.DeserializeEmployees();

            ListBox listBox = _view.GetListBox();

            // Wyczyszczenie ListBox'a przed dodaniem nowych elementów
            listBox.Items.Clear();

            foreach (Model.Employee employee in _model.Employees)
            {
                listBox.Items.Add(employee.ToString());
            }
        }

        private void _view_saveEmployee()
        {
            _model.SerializeEmployees();
        }

        
        

       

        // functions 
    }
}
