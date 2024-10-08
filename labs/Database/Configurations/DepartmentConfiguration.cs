using labs.Database.Helpers;
using labs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labs.Database.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        private const string TableName = "cd_department";

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .ToTable(TableName)
                .HasKey(p => p.DepartmentId)
                .HasName($"pk_{TableName}_student_id");

            builder.Property(p => p.DepartmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("department_id")
                .HasComment("Идентификатор записи кафедры");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("c_department_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название кафедры");

            builder.Property(p => p.HeadTeacherId)
                .HasColumnName("f_head_teacher_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("Идентификатор заведующего кафедрой");

            builder.ToTable(TableName)
                .HasOne(p => p.HeadTeacher)
                .WithOne()
                .HasForeignKey<Department>(p => p.HeadTeacherId)
                .HasConstraintName("fk_f_head_teacher_id")
                .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable(TableName)
                .HasIndex(p => p.HeadTeacherId, "idx_fk_f_head_teacher_id");
        }
    }
}
