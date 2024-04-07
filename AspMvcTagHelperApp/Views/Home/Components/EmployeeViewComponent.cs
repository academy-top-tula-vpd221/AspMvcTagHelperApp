namespace AspMvcTagHelperApp.Views.Home.Components
{
    public class EmployeeViewComponent
    {
        public string Invoke(Employee employee)
        {
            return $"Name: {employee.Name}, Age: {employee.Age}";
        }
    }
}
