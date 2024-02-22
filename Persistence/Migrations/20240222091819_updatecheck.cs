using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updatecheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "bookMeetingRooms");

            migrationBuilder.RenameColumn(
                name: "kaniniLocationId",
                table: "bookMeetingRooms",
                newName: "KaniniLocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KaniniLocationId",
                table: "bookMeetingRooms",
                newName: "kaniniLocationId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "bookMeetingRooms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
