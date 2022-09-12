using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagementCMS_Blazor.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    ProjectTaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "varchar(4096)", maxLength: 4096, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.ProjectTaskId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "ProjectTaskId", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is some example content for task 1", "Task 1" },
                    { 2, "This is some example content for task 2", "Task 2" },
                    { 3, "This is some example content for task 3", "Task 3" },
                    { 4, "This is some example content for task 4", "Task 4" },
                    { 5, "This is some example content for task 5", "Task 5" },
                    { 6, "This is some example content for task 6", "Task 6" },
                    { 7, "This is some example content for task 7", "Task 7" },
                    { 8, "This is some example content for task 8", "Task 8" },
                    { 9, "This is some example content for task 9", "Task 9" },
                    { 10, "This is some example content for task 10", "Task 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTasks");
        }
    }
}
