using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labs.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_cd_department_f_head_teacher_id",
                table: "cd_department",
                column: "f_head_teacher_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_cd_department_f_head_teacher_id",
                table: "cd_department");
        }
    }
}
