namespace labs.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public required string Name { get; set; } = string.Empty;

        public int? HeadTeacherId { get; set; }

        public Teacher? HeadTeacher { get; set; }
    }
}
