using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagmant.Migrations
{
    /// <inheritdoc />
    public partial class datatime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duedate",
                table: "TaskItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "TaskItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "TaskItems");

            migrationBuilder.AddColumn<int>(
                name: "Duedate",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
