namespace Employee.DataAccess.Employee
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public IEnumerable<string> GetEmployees()
        {
            return new[] { "Sindhu", "Prem" };
        }
    }
}
