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

		[HttpPost("ByDegree")]
		public async Task<IActionResult> GetTeachersByDegreeAsync(TeacherAcademicDegreeFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherService.GetTeachersByDegreeAsync(filter, cancellationToken);
			return Ok(teachers);
		}

		[HttpPost("ByDepartment")]
		public async Task<IActionResult> GetTeachersByDepartmentAsync(TeacherDepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherService.GetTeachersByDepartmentAsync(filter, cancellationToken);
			return Ok(teachers);
		}

		[HttpPost("ByPosition")]
		public async Task<IActionResult> GetTeachersByPositionAsync(TeacherPositionFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherService.GetTeachersByPositionAsync(filter, cancellationToken);
			return Ok(teachers);
		}
	}
}
