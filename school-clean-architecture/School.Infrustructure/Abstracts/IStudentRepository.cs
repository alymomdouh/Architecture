using School.Data.Entities;
using School.Infrustructure.InfrastructureBases;

namespace School.Infrustructure.Abstracts
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
