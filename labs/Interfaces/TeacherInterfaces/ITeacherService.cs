using labs.Database;
using labs.Filters.TeacherFilters;
using labs.Models;
using Microsoft.EntityFrameworkCore;

namespace labs.Interfaces.TeacherInterfaces
{
	public interface ITeacherService
	{
		public Task<Teacher[]> GetTeachersByDepartmentAsync(TeacherDepartmentFilter filter, CancellationToken cancellationToken);
	}

	public class TeacherService : ITeacherService
	{
		private readonly TeacherDbContext _dbContext;

		public TeacherService(TeacherDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<Teacher[]> GetTeachersByDepartmentAsync(TeacherDepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = _dbContext.Set<Teacher>().Where(t => t.Department.Name == filter.DepartmentName).ToArrayAsync(cancellationToken);
			return teachers;
		}
	}
}
