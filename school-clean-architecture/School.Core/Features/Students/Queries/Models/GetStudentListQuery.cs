using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Queries.Results;

namespace School.Core.Features.Students.Queries.Models
{
    public record GetStudentListQuery() : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
