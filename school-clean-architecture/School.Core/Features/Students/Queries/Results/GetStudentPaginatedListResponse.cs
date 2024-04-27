namespace School.Core.Features.Students.Queries.Results
{
    //public class GetStudentPaginatedListResponse
    //{
    //    public int StudID { get; set; }
    //    public string? Name { get; set; }
    //    public string? Address { get; set; }
    //    public string? DepartmentName { get; set; }
    //}
    public record GetStudentPaginatedListResponse(int StudID, string? Name, string? Address, string? DepartmentName)
    {
    }
}