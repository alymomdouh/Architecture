using MediatR;
using School.Core.Bases;
using School.Core.Features.Students.Queries.Results;

namespace School.Core.Features.Students.Queries.Models
{
    //public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    //{
    //    public int Id { get; set; }
    //    public GetStudentByIDQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}
    public record GetStudentByIDQuery(int Id) : IRequest<Response<GetSingleStudentResponse>>
    {
    }
}