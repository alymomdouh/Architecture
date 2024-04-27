using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstracts;
using School.Infrustructure.Context;
using School.Infrustructure.InfrastructureBases;

namespace School.Infrustructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subjects>, ISubjectRepository
    {
        #region Fields
        private DbSet<Subjects> subjects;
        #endregion

        #region Constructors
        public SubjectRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            subjects = dbContext.Set<Subjects>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
