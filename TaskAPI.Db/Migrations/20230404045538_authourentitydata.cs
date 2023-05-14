using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.Db.Migrations
{
    /// <inheritdoc />
    public partial class authourentitydata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthourId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authours", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Authours",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Mudeesha Tharindu" },
                    { 2, "John Cena" },
                    { 3, "Breat Lee" },
                    { 4, "Sharuk Khan" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthourId", "Createdd", "Due" },
                values: new object[] { 1, new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthourId", "Createdd", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6949), "Get some text book for school", new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6949), 0, "Need some grocceries" },
                    { 3, 2, new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6951), "Get vegitables for the week", new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6951), 0, "Get books fro school from db" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthourId",
                table: "Todos",
                column: "AuthourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authours_AuthourId",
                table: "Todos",
                column: "AuthourId",
                principalTable: "Authours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authours_AuthourId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authours");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthourId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthourId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 3, 13, 44, 32, 845, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 4, 3, 13, 44, 32, 845, DateTimeKind.Local).AddTicks(878) });
        }
    }
}
