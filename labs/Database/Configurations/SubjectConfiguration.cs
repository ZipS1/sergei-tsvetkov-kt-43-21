using labs.Database.Helpers;
using labs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace labs.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .ToTable(TableName)
                .HasKey(p => p.SubjectId);

            builder.Property(p => p.SubjectId)
                .ValueGeneratedOnAdd()
                .HasColumnName("subject_id")
                .HasComment("Идентификатор записи предмета");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnName("subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название предмета");

            builder.Property(p => p.TeacherId)
                .IsRequired()
                .HasColumnName("f_teacher_id")
                .HasColumnType(ColumnType.Int)
                .HasComment("Идентификатор преподавателя");

            builder
                .HasOne(p => p.Teacher)
                .WithMany()
                .HasForeignKey(p => p.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Navigation(p => p.Teacher)
                .AutoInclude();
        }
    }
}
