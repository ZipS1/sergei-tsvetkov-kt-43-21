using labs.Interfaces.TeacherInterfaces;

namespace labs.ServiceExtensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddScoped<ITeacherGetterService, TeacherGetterService>();
			services.AddScoped<ITeacherModifierService, TeacherModifierService>();
			return services;
		}
	}
}
