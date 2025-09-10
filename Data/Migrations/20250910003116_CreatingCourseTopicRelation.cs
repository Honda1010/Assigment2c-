using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAss2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingCourseTopicRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                schema: "dbo",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                schema: "dbo",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TopicId",
                schema: "dbo",
                table: "Courses");
        }
    }
}
