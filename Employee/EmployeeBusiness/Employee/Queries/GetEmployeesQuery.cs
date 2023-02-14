using Employee.Business.Employee.Responses;
using MediatR;

namespace Employee.Business.Employee.Queries
{
    public class GetEmployeesQuery : IRequest<GetEmployeesResponse>
    {
    }
}
