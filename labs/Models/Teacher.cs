namespace labs.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public required string Position { get; set; }

        public string? AcademicDegree { get; set; }

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
