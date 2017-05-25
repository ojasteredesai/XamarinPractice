using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo3.Chapter17
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeGridPage : ContentPage
    {
        public List<Employee> Employees { get; set; }
        public EmployeeGridPage()
        {
            InitializeComponent();
            this.Employees = this.GetEmployees();
            BindDataToGrid();
        }

        void BindDataToGrid()
        {
            if (this.Employees != null && this.Employees.Any())
            {
                var RowDefinitions = new RowDefinitionCollection();

                for (int i = 0; i < Employees.Count; i++)
                {
                    RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                    var lblName = new Label
                    {
                        Text = Employees[i].Name,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };

                    Grid.SetRow(lblName, i);
                    Grid.SetColumn(lblName,0);
                    grdEmployees.Children.Add(lblName);

                    var lblDepartment = new Label
                    {
                        Text = Employees[i].Department,                       
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };

                    Grid.SetRow(lblDepartment, i);
                    Grid.SetColumn(lblDepartment, 1);
                    grdEmployees.Children.Add(lblDepartment);

                    var lblAge = new Label
                    {
                        Text = Employees[i].Age.ToString(),
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };

                    Grid.SetRow(lblAge, i);
                    Grid.SetColumn(lblAge, 2);
                    grdEmployees.Children.Add(lblAge);
                }
            }
        }

        List<Employee> GetEmployees()
        {
            return new List<Employee>
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
                },
                new Employee
                {
                    Id = 4,
                    Age=25,
                    Department="Admin",
                    Gender="M",
                    Name= "Russel Vendrol"
                },
                new Employee
                {
                    Id = 5,
                    Age=24,
                    Department="Operations",
                    Gender="F",
                    Name= "Kety Swanson"
                },
                new Employee
                {
                    Id = 6,
                    Age=44,
                    Department="HR Services",
                    Gender="F",
                    Name= "Gini Twenor"
                },
            };
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
