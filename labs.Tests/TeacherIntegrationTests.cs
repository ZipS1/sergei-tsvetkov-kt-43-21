using labs.Database;
using labs.Filters.TeacherFilters;
using labs.Interfaces.TeacherInterfaces;
using labs.Models;
using Microsoft.EntityFrameworkCore;

namespace labs.Tests
{
	public class TeacherIntegrationTests
	{
		public readonly DbContextOptions<TeacherDbContext> _dbContextOptions;

		public TeacherIntegrationTests()
		{
			_dbContextOptions = new DbContextOptionsBuilder<TeacherDbContext>()
				.UseInMemoryDatabase("pp_student_db_test")
				.Options;
		}

		[Fact]
		public async Task GetStudentsByGroupAsync_Cathedra1_TwoObjects()
		{
			// Arrange
			var ctx = new TeacherDbContext(_dbContextOptions);
			var teacherGetterService = new TeacherGetterService(ctx);
			var departments = new List<Department>
			{
				new Department
				{
					DepartmentId = 1,
					Name = "Cathedra1",
				},
				new Department
				{
					DepartmentId = 2,
					Name = "Cathedra2",
				}
			};
			await ctx.Set<Department>().AddRangeAsync(departments);

			var teachers = new List<Teacher>
			{
				new Teacher
				{
					FirstName = "first1",
					LastName = "first1",
					MiddleName = "first1",
					Position = "first1",
					DepartmentId = 1
				},
				new Teacher
				{
					FirstName = "second",
					LastName = "second",
					MiddleName = "second",
					Position = "second",
					DepartmentId = 2,
				},
				new Teacher
				{
					FirstName = "first2",
					LastName = "first2",
					MiddleName = "first2",
					Position = "first2",
					DepartmentId = 1,
				}
			};
			await ctx.Set<Teacher>().AddRangeAsync(teachers);
			await ctx.SaveChangesAsync();

			// Act
			var filter = new TeacherDepartmentFilter()
			{
				DepartmentName = "Cathedra1"
			};

			var teachersResult = await teacherGetterService.GetTeachersByDepartmentAsync(filter);

			// Assert
			Assert.Equal(2, teachersResult.Length);
		}
	}
}
