﻿using Practice_Management.Library.Models;
using Practice_Management.Library.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practice_Management.MAUI.ViewModels
{
    public class TimeViewModel : INotifyPropertyChanged
    {
        public Time Model { get; set; }

        public string HourDisplay 
        {
            get
            {
                return Model.Hours.ToString();
            }
            set
            {
                if(Decimal.TryParse(value , out decimal v))
                {
                    Model.Hours = v;
                }
            }
        }

        private Employee employee;

        public Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                if(employee != null)
                {
                    Model.EmployeeId = employee.ID;
                }
            }
        }

        public string EmployeeDisplay => Employee?.Name ?? string.Empty;

        private Project project;

        public Project Project {
            get
            {
                return project;
            }
            set
            {
                project = value;
                if(project != null)
                {
                    Model.ProjectId = project.ID;
                }
            }
        }

        public string ProjectDisplay => Project?.ShortName ?? string.Empty;

        public ICommand DeleteCommand { get; private set; }

        public ICommand EditCommand { get; private set; }

        public void ExecuteDelete()
        {
            TimeService.Current.Delete(Model);
            NotifyPropertyChanged(nameof(Time));
        }

        public void ExecuteEdit()
        {
            Shell.Current.GoToAsync($"//TimerEdit?timeID={Model.Id}");
        }

        public void SetUpCommands()
        {
            DeleteCommand = new Command(ExecuteDelete);
            EditCommand = new Command(ExecuteEdit);
        }

        public ObservableCollection<Employee> Employees 
            => new ObservableCollection<Employee>(EmployeeService.Current.Employees);

        public ObservableCollection<Project> Projects
            => new ObservableCollection<Project>(ProjectService.Current.Projects);


        public TimeViewModel() 
        {
            Model = new Time();
            SetUpCommands();
        }

        public TimeViewModel(Time t)
        {
            Model = t;
            var employee = EmployeeService.Current.Get(t.EmployeeId);
            if(employee != null)
            {
                Employee = employee;
            }
            var project = ProjectService.Current.Get(t.ProjectId);
            if(project != null)
            {
                Project = project;
            }
            SetUpCommands();
        }

        public TimeViewModel(int tid)
        {
            if(tid > 0)
            {
                Model = TimeService.Current.Get(tid);
                SetUpCommands();
            }
        }

        public void AddOrUpdate()
        {
            TimeService.Current.AddOrUpdate(Model);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
