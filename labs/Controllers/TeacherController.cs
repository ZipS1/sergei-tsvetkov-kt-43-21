using labs.Filters.TeacherFilters;
using labs.Interfaces.TeacherInterfaces;
using labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace labs.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TeacherController : ControllerBase
	{
		private readonly ILogger<TeacherController> _logger;
		private readonly ITeacherGetterService _teacherGetterService;
		private readonly ITeacherModifierService _teacherModifierService;

		public TeacherController(ILogger<TeacherController> logger, ITeacherGetterService teacherGetterService, ITeacherModifierService teacherModifierService)
		{
			_logger = logger;
			_teacherGetterService = teacherGetterService;
			_teacherModifierService = teacherModifierService;
		}

		[HttpPost("GetByDegree")]
		public async Task<IActionResult> GetTeachersByDegreeAsync(TeacherAcademicDegreeFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherGetterService.GetTeachersByDegreeAsync(filter, cancellationToken);
			return Ok(teachers);
		}

		[HttpPost("GetByDepartment")]
		public async Task<IActionResult> GetTeachersByDepartmentAsync(TeacherDepartmentFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherGetterService.GetTeachersByDepartmentAsync(filter, cancellationToken);
			return Ok(teachers);
		}

		[HttpPost("GetByPosition")]
		public async Task<IActionResult> GetTeachersByPositionAsync(TeacherPositionFilter filter, CancellationToken cancellationToken = default)
		{
			var teachers = await _teacherGetterService.GetTeachersByPositionAsync(filter, cancellationToken);
			return Ok(teachers);
		}

        [HttpPost("GetByName")]
        public async Task<IActionResult> GetTeachersByNameAsync(TeacherNameFilter filter, CancellationToken cancellationToken = default)
        {
            var teachers = await _teacherGetterService.GetTeachersByNameAsync(filter, cancellationToken);
            return Ok(teachers);
        }

        [HttpPost("Create")]
		public async Task<IActionResult> CreateTeacherAsync(Teacher teacher, CancellationToken cancellationToken = default)
		{
			await _teacherModifierService.CreateTeacherAsync(teacher, cancellationToken);
			return Ok();
		}

		[HttpPost("Edit")]
		public async Task<IActionResult> EditTeacherAsync(Teacher teacher, CancellationToken cancellationToken = default)
		{
			await _teacherModifierService.EditTeacherAsync(teacher, cancellationToken);
			return Ok();
		}

		[HttpPost("Remove")]
		public async Task<IActionResult> RemoveTeacherAsync(Teacher teacher, CancellationToken cancellationToken = default)
		{
			await _teacherModifierService.RemoveTeacherAsync(teacher, cancellationToken);
			return Ok();
		}
	}
}
