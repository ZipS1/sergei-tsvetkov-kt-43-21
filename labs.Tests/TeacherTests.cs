using labs.Models;

namespace labs.Tests
{
	public class TeacherTests
	{
		[Fact]
		public void HasAcademicDegree_Null_False()
		{
			var teacher = new Teacher
			{
				TeacherId = 1,
				FirstName = "����",
				MiddleName = "��������",
				LastName = "������",
				Position = "��. ������",
				AcademicDegree = null,
				DepartmentId = 1,
				Department = null
			};

			var result = teacher.HasAcademicDegree();

			Assert.False(result);
		}

		[Fact]
		public void HasAcademicDegree_Ktn_True()
		{
			var teacher = new Teacher
			{
				TeacherId = 1,
				FirstName = "����",
				MiddleName = "��������",
				LastName = "������",
				Position = "��. ������",
				AcademicDegree = "�.�.�",
				DepartmentId = 1,
				Department = null
			};

			var result = teacher.HasAcademicDegree();

			Assert.True(result);
		}
	}
}