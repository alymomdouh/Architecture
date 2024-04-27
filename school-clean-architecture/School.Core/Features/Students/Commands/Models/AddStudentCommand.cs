﻿using MediatR;
using School.Core.Bases;

namespace School.Core.Features.Students.Commands.Models
{
    //public class AddStudentCommand : IRequest<Response<string>>
    //{
    //    public string NameAr { get; set; }
    //    public string NameEn { get; set; }
    //    public string Address { get; set; }
    //    public string Phone { get; set; }
    //    public int DepartmementId { get; set; }
    //}
    public record AddStudentCommand(string NameAr, string NameEn, string Address, string Phone, int DepartmementId)
                      : IRequest<Response<string>>
    {
    }
}
