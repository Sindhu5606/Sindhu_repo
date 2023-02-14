using Employee.DataAccess.Employee;

namespace Employee.Repository.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeDataAccess _employeeDataAccess;
        public EmployeeRepository(IEmployeeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }
        public IEnumerable<string> GetAllEmployees()
        {
            var employees = _employeeDataAccess.GetEmployees();
            return employees;
        }
    }
}
