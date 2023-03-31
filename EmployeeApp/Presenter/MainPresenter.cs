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
            _view.addEmployee += _view_addEmployee1;
            _view.getName += _view_getName;
            _view.getLastName += _view_getLastName;

        }

        private void _view_getLastName(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_getName(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_addEmployee1()
        {
            throw new NotImplementedException();
        }

        private void _view_loadEmployee()
        {
            throw new NotImplementedException();
        }

        private void _view_saveEmployee()
        {
            throw new NotImplementedException();
        }

        private void _view_getJobType(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_getJob(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_getSalary(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_getDob(string obj)
        {
            throw new NotImplementedException();
        }

        private void _view_addEmployee()
        {
            throw new NotImplementedException();
        }

       

        // functions 
    }
}
