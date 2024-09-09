using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labs.Migrations
{
    /// <inheritdoc />
    public partial class RenameDepartmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teacher_Departments_f_department_id",
                table: "teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "department");

            migrationBuilder.AddPrimaryKey(
                name: "PK_department",
                table: "department",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_teacher_department_f_department_id",
                table: "teacher",
                column: "f_department_id",
                principalTable: "department",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teacher_department_f_department_id",
                table: "teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_department",
                table: "department");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_teacher_Departments_f_department_id",
                table: "teacher",
                column: "f_department_id",
                principalTable: "Departments",
                principalColumn: "department_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
