using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace congestion.calculator.Migrations
{
    /// <inheritdoc />
    public partial class CreateTimeAmountTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FreeDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAmounts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FreeDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2013, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2013, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2013, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2013, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2013, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2013, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2013, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TimeAmounts",
                columns: new[] { "Id", "Amount", "Currency", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 8, "SEK", new TimeSpan(0, 6, 29, 0, 0), new TimeSpan(0, 6, 0, 0, 0) },
                    { 2, 13, "SEK", new TimeSpan(0, 6, 59, 0, 0), new TimeSpan(0, 6, 30, 0, 0) },
                    { 3, 18, "SEK", new TimeSpan(0, 7, 59, 0, 0), new TimeSpan(0, 7, 0, 0, 0) },
                    { 4, 13, "SEK", new TimeSpan(0, 8, 29, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 5, 8, "SEK", new TimeSpan(0, 14, 59, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 6, 13, "SEK", new TimeSpan(0, 15, 29, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 7, 18, "SEK", new TimeSpan(0, 16, 59, 0, 0), new TimeSpan(0, 15, 30, 0, 0) },
                    { 8, 13, "SEK", new TimeSpan(0, 17, 59, 0, 0), new TimeSpan(0, 17, 0, 0, 0) },
                    { 9, 8, "SEK", new TimeSpan(0, 18, 29, 0, 0), new TimeSpan(0, 18, 0, 0, 0) },
                    { 10, 0, "SEK", new TimeSpan(0, 23, 59, 0, 0), new TimeSpan(0, 18, 30, 0, 0) },
                    { 11, 0, "SEK", new TimeSpan(0, 5, 59, 0, 0), new TimeSpan(0, 0, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreeDates");

            migrationBuilder.DropTable(
                name: "TimeAmounts");
        }
    }
}
