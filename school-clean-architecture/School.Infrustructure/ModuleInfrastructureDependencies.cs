using Microsoft.Extensions.DependencyInjection;
using School.Infrustructure.Abstracts;
using School.Infrustructure.InfrastructureBases;
using School.Infrustructure.Repositories;

namespace School.Infrustructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorsRepository, InstructorsRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            //services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

            ////views
            //services.AddTransient<IViewRepository<ViewDepartment>, ViewDepartmentRepository>();

            ////Procedure
            //services.AddTransient<IDepartmentStudentCountProcRepository, DepartmentStudentCountProcRepository>();

            ////functions
            //services.AddTransient<IInstructorFunctionsRepository, InstructorFunctionsRepository>();

            return services;
        }
    }
}
