using TestMehdi.Entity;

namespace TestMehdi.Business
{
    public class EmployeeBusiness
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeBusiness()
        {
            employees.Add(new Employee() { Age = 2 , Id = 1 , Name = "reza"});
            employees.Add(new Employee() { Age = 2 , Id = 1 , Name = "mehdi"});

        }

        public List<Employee> Employees()
        {
            return employees;
        }
    }
}
