using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blazor_server_dashboard.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "AssignedBy", "AssignedTo", "CompletionDate", "Description", "DueDate", "Priority", "StartDate" },
                values: new object[,]
                {
                    { 1, "Neil Ranada", "Katelyn Pham", null, "Sign security agreements", new DateOnly(2023, 11, 16), "Low", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(3761) },
                    { 2, "Neil Ranada", "Neil Ranada", null, "Review code", new DateOnly(2023, 11, 16), "Low", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(3954) },
                    { 3, "Keisha Weiland", "Katelyn Pham", new DateOnly(2023, 10, 1), "Complete cybersecurity training", new DateOnly(2023, 11, 16), "Medium", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(4001) },
                    { 4, "Neil Ranada", "Billy Dietz", new DateOnly(2023, 10, 2), "Audit security program", new DateOnly(2023, 11, 20), "Medium", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(4041) },
                    { 5, "Keisha Weiland", "Diane Basham", new DateOnly(2023, 10, 3), "Fix security vulnerability", new DateOnly(2023, 11, 20), "High", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(4083) },
                    { 6, "Neil Ranada", "Tammy Wescott", null, "Review and approve security plan", new DateOnly(2023, 12, 5), "Medium", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(4131) },
                    { 7, "Grace Hopper", "Neil Ranada", new DateOnly(2023, 10, 2), "Find bugs", new DateOnly(2023, 12, 15), "Low", new DateTime(2023, 10, 9, 22, 30, 47, 151, DateTimeKind.Local).AddTicks(4171) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
