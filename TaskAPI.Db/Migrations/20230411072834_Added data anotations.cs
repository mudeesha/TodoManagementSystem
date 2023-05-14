using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.Db.Migrations
{
    /// <inheritdoc />
    public partial class Addeddataanotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authours",
                keyColumn: "FullName",
                keyValue: null,
                column: "FullName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authours",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AddressNo",
                table: "Authours",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authours",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authours",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Authours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "827/1", "colombo", "Street 1" });

            migrationBuilder.UpdateData(
                table: "Authours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "750", "Galle", "Street 2" });

            migrationBuilder.UpdateData(
                table: "Authours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "103", "Matara", "Street 3" });

            migrationBuilder.UpdateData(
                table: "Authours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddressNo", "City", "Street" },
                values: new object[] { "85", "kandy", "Street 4" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4393), new DateTime(2023, 4, 16, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 4, 16, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 11, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 4, 16, 12, 58, 34, 322, DateTimeKind.Local).AddTicks(4409) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressNo",
                table: "Authours");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authours");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authours");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authours",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6949), new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Createdd", "Due" },
                values: new object[] { new DateTime(2023, 4, 4, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6951), new DateTime(2023, 4, 9, 10, 25, 38, 304, DateTimeKind.Local).AddTicks(6951) });
        }
    }
}
