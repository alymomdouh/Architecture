using School.Data.Entities;

namespace School.Service.Abstracts
{
    public interface IDepartmentService
    {
        public Task<Department> GetDepartmentById(int id);
        public Task<bool> IsDepartmentIdExist(int departmentId);
       // public Task<List<ViewDepartment>> GetViewDepartmentDataAsync();
       // public Task<IReadOnlyList<DepartmentStudentCountProc>> GetDepartmentStudentCountProcs(DepartmentStudentCountProcParameters parameters);
    }
}
