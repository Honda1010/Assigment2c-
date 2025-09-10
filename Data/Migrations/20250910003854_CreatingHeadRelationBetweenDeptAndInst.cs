using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAss2.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingHeadRelationBetweenDeptAndInst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeadId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadId",
                table: "Departments",
                column: "HeadId",
                unique: true,
                filter: "[HeadId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_HeadId",
                table: "Departments",
                column: "HeadId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_HeadId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_HeadId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "HeadId",
                table: "Departments");
        }
    }
}
