namespace Employee.DataAccess.Employee
{
    public interface IEmployeeDataAccess
    {
        IEnumerable<string> GetEmployees();
    }
}
