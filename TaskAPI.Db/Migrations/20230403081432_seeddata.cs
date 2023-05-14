using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Db.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Createdd", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2023, 4, 3, 13, 44, 32, 845, DateTimeKind.Local).AddTicks(866), "Get vegitables for the week", new DateTime(2023, 4, 3, 13, 44, 32, 845, DateTimeKind.Local).AddTicks(878), 0, "Get books fro school from db" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
