﻿namespace School.Core.Features.Students.Queries.Results
{
    //public class GetSingleStudentResponse
    //{
    //    public int StudID { get; set; }
    //    public string? Name { get; set; }
    //    public string? Address { get; set; }
    //    public string? DepartmentName { get; set; }
    //}
    public record GetSingleStudentResponse(int StudID, string? Name, string? Address, string? DepartmentName)
    {
    }
}
