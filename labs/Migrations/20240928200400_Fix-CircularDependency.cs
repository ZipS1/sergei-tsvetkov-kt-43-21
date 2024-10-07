using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace labs.Migrations
{
    /// <inheritdoc />
    public partial class FixCircularDependency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department");

            migrationBuilder.AlterColumn<int>(
                name: "f_head_teacher_id",
                table: "cd_department",
                type: "int4",
                nullable: true,
                comment: "Идентификатор заведующего кафедрой",
                oldClrType: typeof(int),
                oldType: "int4",
                oldComment: "Идентификатор заведующего кафедрой");

            migrationBuilder.AddForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department",
                column: "f_head_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department");

            migrationBuilder.AlterColumn<int>(
                name: "f_head_teacher_id",
                table: "cd_department",
                type: "int4",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор заведующего кафедрой",
                oldClrType: typeof(int),
                oldType: "int4",
                oldNullable: true,
                oldComment: "Идентификатор заведующего кафедрой");

            migrationBuilder.AddForeignKey(
                name: "fk_f_head_teacher_id",
                table: "cd_department",
                column: "f_head_teacher_id",
                principalTable: "cd_teacher",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
