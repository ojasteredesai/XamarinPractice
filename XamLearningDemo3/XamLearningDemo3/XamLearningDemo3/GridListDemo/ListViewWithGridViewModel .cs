using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamLearningDemo3.GridListDemo
{
    public class ListViewWithGridViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _myObservableCollection;
        private ObservableCollection<Employee> employees { get; set; }

        public ListViewWithGridViewModel()
        {
            MyObservableCollection = new ObservableCollection<string>(new List<string> { "abc", "xyz", "pqr", "aaa", "abc", "xyz", "pqr", "aaa", "abc", "xyz", "pqr", "aaa" });

            this.Employees = this.GetEmployees();
        }

        public ObservableCollection<string> MyObservableCollection
        {
            get { return _myObservableCollection; }
            set
            {
                _myObservableCollection = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ObservableCollection<Employee> GetEmployees()
        {
            return new ObservableCollection<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Age=23,
                    Department="IT Development",
                    Gender="M",
                    Name= "Steve Carl"
                },
                new Employee
                {
                    Id = 2,
                    Age=32,
                    Department="IT Support",
                    Gender="F",
                    Name= "Sarah Orashel"
                },
                new Employee
                {
                    Id = 3,
                    Age=45,
                    Department="HR Services",
                    Gender="F",
                    Name= "Amanda Lawson"
                }
            };
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Department { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    //public class Employee 
    //{
    //    public int Id { get; set; }

    //    private string name;
    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }
    //    public string Department { get; set; }
    //    public string Gender { get; set; }
    //    public int Age { get; set; }
    //}
}
