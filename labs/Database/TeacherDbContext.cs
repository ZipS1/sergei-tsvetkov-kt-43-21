using labs.Database.Configurations;
using labs.Models;
using Microsoft.EntityFrameworkCore;

namespace labs.Database
{
    public class TeacherDbContext : DbContext
    {
        DbSet<Department> Departments { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }

        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options) {}
    }
}
