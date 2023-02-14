using Employee.Business.Employee.Queries;
using Employee.Business.Employee.Responses;
using Employee.Core.Options;
using Employee.Repository.Employee;
using MediatR;
using Microsoft.Extensions.Options;

namespace Employee.Business.Employee.Handlers
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, GetEmployeesResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ConnectionStringOptions _connectionStringOptions;
        public GetEmployeesQueryHandler(IEmployeeRepository employeeRepository,  IOptions<ConnectionStringOptions> connectionStringOptions)
        {
            _employeeRepository = employeeRepository;
            _connectionStringOptions = connectionStringOptions.Value;
        }
        public async Task<GetEmployeesResponse> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = _employeeRepository.GetAllEmployees();
            var response = new GetEmployeesResponse() { Employees = employees };
            return response;
        }
    }
}
