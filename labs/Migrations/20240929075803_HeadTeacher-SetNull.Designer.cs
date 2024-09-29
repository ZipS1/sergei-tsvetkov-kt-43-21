﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using labs.Database;

#nullable disable

namespace labs.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    [Migration("20240929075803_HeadTeacher-SetNull")]
    partial class HeadTeacherSetNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("labs.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("department_id")
                        .HasComment("Идентификатор записи кафедры");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.Property<int?>("HeadTeacherId")
                        .HasColumnType("int4")
                        .HasColumnName("f_head_teacher_id")
                        .HasComment("Идентификатор заведующего кафедрой");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_department_name")
                        .HasComment("Название кафедры");

                    b.HasKey("DepartmentId")
                        .HasName("pk_cd_department_student_id");

                    b.HasIndex(new[] { "HeadTeacherId" }, "idx_fk_f_head_teacher_id");

                    b.ToTable("cd_department", (string)null);
                });

            modelBuilder.Entity("labs.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("subject_id")
                        .HasComment("Идентификатор записи предмета");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_subject_name")
                        .HasComment("Название предмета");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int4")
                        .HasColumnName("f_teacher_id")
                        .HasComment("Идентификатор преподавателя");

                    b.HasKey("SubjectId");

                    b.HasIndex(new[] { "TeacherId" }, "idx_cd_subject_fk_f_teacher_id");

                    b.ToTable("cd_subject", (string)null);
                });

            modelBuilder.Entity("labs.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id")
                        .HasComment("Идентификатор записи преподавателя");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("AcademicDegree")
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_academic_degree")
                        .HasComment("Ученая степень преподавателя");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int4")
                        .HasColumnName("f_department_id")
                        .HasComment("Идентификатор кафедры");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_firstname")
                        .HasComment("Имя преподавателя");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_lastname")
                        .HasComment("Фамилия преподавателя");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_middlename")
                        .HasComment("Отчество преподавателя");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_position")
                        .HasComment("Должность преподавателя");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex(new[] { "DepartmentId" }, "idx_cd_teacher_fk_f_department_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("labs.Models.Department", b =>
                {
                    b.HasOne("labs.Models.Teacher", "HeadTeacher")
                        .WithMany()
                        .HasForeignKey("HeadTeacherId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_f_head_teacher_id");

                    b.Navigation("HeadTeacher");
                });

            modelBuilder.Entity("labs.Models.Subject", b =>
                {
                    b.HasOne("labs.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_teacher_id");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("labs.Models.Teacher", b =>
                {
                    b.HasOne("labs.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_department_id");

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
