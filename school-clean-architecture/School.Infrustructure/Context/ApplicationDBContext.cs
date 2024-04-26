using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using System.Reflection;

namespace School.Infrustructure.Context
{
    public class ApplicationDBContext : DbContext
    //IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        ///private readonly IEncryptionProvider _encryptionProvider;
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            //  _encryptionProvider = new GenerateEncryptionProvider("8a4dcaaec64d412380fe4b02193cd26f");
        }
        // public DbSet<User> User { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<DepartmetSubject> departmetSubjects { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
        // public DbSet<UserRefreshToken> UserRefreshToken { get; set; }

        #region Views
        // public DbSet<ViewDepartment> ViewDepartment { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<DepartmetSubject>()
                        .HasKey(m => new { m.DID, m.SubID });
            modelBuilder.Entity<Ins_Subject>()
                        .HasKey(m => new { m.InsId, m.SubId });
            modelBuilder.Entity<StudentSubject>()
                       .HasKey(m => new { m.SubID, m.StudID });
             
            // modelBuilder.UseEncryption(_encryptionProvider);
        }
    }
}
