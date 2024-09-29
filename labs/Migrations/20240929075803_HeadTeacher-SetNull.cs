using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labs.Migrations
{
    /// <inheritdoc />
    public partial class HeadTeacherSetNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department");

            migrationBuilder.AddForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department",
                column: "f_head_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department");

            migrationBuilder.AddForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department",
                column: "f_head_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id");
        }
    }
}
