using labs.Filters.TeacherFilters;
using labs.Interfaces.TeacherInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace labs.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TeacherController : ControllerBase
	{
		private readonly ILogger<TeacherController> _logger;
		private readonly ITeacherService _teacherService;

		public TeacherController(ILogger<TeacherController> logger, ITeacherService teacherService)
		{
			_logger = logger;
			_teacherService = teacherService;
		}

		[HttpPost("GetTeachers")]
		public async Task<IActionResult> GetTeachersByDepartmentAsync(TeacherDepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherService.GetTeachersByDepartmentAsync(filter, cancellationToken);
			return Ok(teachers);
		}
	}
}
