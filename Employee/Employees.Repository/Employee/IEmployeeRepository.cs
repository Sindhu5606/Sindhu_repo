namespace Employee.Repository.Employee
{
    public interface IEmployeeRepository
    {
        IEnumerable<string> GetAllEmployees();
    }
}
