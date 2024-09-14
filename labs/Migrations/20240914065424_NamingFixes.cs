using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labs.Migrations
{
    /// <inheritdoc />
    public partial class NamingFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subject_teacher_f_teacher_id",
                table: "subject");

            migrationBuilder.DropForeignKey(
                name: "FK_teacher_department_f_department_id",
                table: "teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teacher",
                table: "teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subject",
                table: "subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_department",
                table: "department");

            migrationBuilder.RenameTable(
                name: "teacher",
                newName: "cd_teacher");

            migrationBuilder.RenameTable(
                name: "subject",
                newName: "cd_subject");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "cd_department");

            migrationBuilder.RenameColumn(
                name: "teacher_middlename",
                table: "cd_teacher",
                newName: "c_teacher_middlename");

            migrationBuilder.RenameColumn(
                name: "teacher_lastname",
                table: "cd_teacher",
                newName: "c_teacher_lastname");

            migrationBuilder.RenameColumn(
                name: "teacher_firstname",
                table: "cd_teacher",
                newName: "c_teacher_firstname");

            migrationBuilder.RenameIndex(
                name: "IX_teacher_f_department_id",
                table: "cd_teacher",
                newName: "idx_cd_teacher_fk_f_department_id");

            migrationBuilder.RenameColumn(
                name: "subject_name",
                table: "cd_subject",
                newName: "c_subject_name");

            migrationBuilder.RenameIndex(
                name: "IX_subject_f_teacher_id",
                table: "cd_subject",
                newName: "idx_cd_subject_fk_f_teacher_id");

            migrationBuilder.RenameColumn(
                name: "department_name",
                table: "cd_department",
                newName: "c_department_name");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_teacher_teacher_id",
                table: "cd_teacher",
                column: "teacher_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cd_subject",
                table: "cd_subject",
                column: "subject_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cd_department_student_id",
                table: "cd_department",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "fk_f_teacher_id",
                table: "cd_subject",
                column: "f_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_f_department_id",
                table: "cd_teacher",
                column: "f_department_id",
                principalTable: "cd_department",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_teacher_id",
                table: "cd_subject");

            migrationBuilder.DropForeignKey(
                name: "fk_f_department_id",
                table: "cd_teacher");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_teacher_teacher_id",
                table: "cd_teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cd_subject",
                table: "cd_subject");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cd_department_student_id",
                table: "cd_department");

            migrationBuilder.RenameTable(
                name: "cd_teacher",
                newName: "teacher");

            migrationBuilder.RenameTable(
                name: "cd_subject",
                newName: "subject");

            migrationBuilder.RenameTable(
                name: "cd_department",
                newName: "department");

            migrationBuilder.RenameColumn(
                name: "c_teacher_middlename",
                table: "teacher",
                newName: "teacher_middlename");

            migrationBuilder.RenameColumn(
                name: "c_teacher_lastname",
                table: "teacher",
                newName: "teacher_lastname");

            migrationBuilder.RenameColumn(
                name: "c_teacher_firstname",
                table: "teacher",
                newName: "teacher_firstname");

            migrationBuilder.RenameIndex(
                name: "idx_cd_teacher_fk_f_department_id",
                table: "teacher",
                newName: "IX_teacher_f_department_id");

            migrationBuilder.RenameColumn(
                name: "c_subject_name",
                table: "subject",
                newName: "subject_name");

            migrationBuilder.RenameIndex(
                name: "idx_cd_subject_fk_f_teacher_id",
                table: "subject",
                newName: "IX_subject_f_teacher_id");

            migrationBuilder.RenameColumn(
                name: "c_department_name",
                table: "department",
                newName: "department_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teacher",
                table: "teacher",
                column: "teacher_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subject",
                table: "subject",
                column: "subject_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_department",
                table: "department",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_subject_teacher_f_teacher_id",
                table: "subject",
                column: "f_teacher_id",
                principalTable: "teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teacher_department_f_department_id",
                table: "teacher",
                column: "f_department_id",
                principalTable: "department",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
