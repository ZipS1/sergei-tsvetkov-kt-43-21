namespace labs.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public required string FirstName { get; set; } = string.Empty;

        public required string LastName { get; set; } = string.Empty;

        public required string MiddleName { get; set; } = string.Empty;

        public required string Position { get; set; } = string.Empty;

        public string? AcademicDegree { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }

        public bool HasAcademicDegree() => AcademicDegree != null;
    }
}
