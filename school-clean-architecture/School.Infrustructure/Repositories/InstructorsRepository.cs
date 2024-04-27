using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstracts;
using School.Infrustructure.Context;
using School.Infrustructure.InfrastructureBases;

namespace School.Infrustructure.Repositories
{
    public class InstructorsRepository : GenericRepositoryAsync<Instructor>, IInstructorsRepository
    {
        #region Fields
        private DbSet<Instructor> instructors;
        #endregion

        #region Constructors
        public InstructorsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            instructors = dbContext.Set<Instructor>();
        }
        #endregion 
        #region Handle Functions 
        #endregion
    }
}
