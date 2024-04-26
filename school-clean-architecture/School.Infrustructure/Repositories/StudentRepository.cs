using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstracts;
using School.Infrustructure.Context;
using School.Infrustructure.InfrastructureBases;

namespace School.Infrustructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _students;
        #endregion

        #region Constructors
        public StudentRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
            _students = dBContext.Set<Student>();
        }
        #endregion

        #region Handles Functions
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x => x.Department).ToListAsync();
        }
        #endregion 
    }
}