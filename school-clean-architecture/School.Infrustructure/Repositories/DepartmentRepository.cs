using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrustructure.Abstracts;
using School.Infrustructure.Context;
using School.Infrustructure.InfrastructureBases;

namespace School.Infrustructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {
        #region Fields
        private DbSet<Department> departments;
        #endregion

        #region Constructors
        public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            departments = dbContext.Set<Department>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}