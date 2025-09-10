using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAss2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingStudentCourseRelation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Courses_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_StudentId",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "Stud_Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Courses",
                newName: "IX_Stud_Courses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses",
                column: "CourseId",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_StudentId",
                table: "Stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.RenameTable(
                name: "Stud_Courses",
                newName: "Stud_Course");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Courses_CourseId",
                table: "Stud_Course",
                newName: "IX_Stud_Course_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Courses_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_StudentId",
                table: "Stud_Course",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
