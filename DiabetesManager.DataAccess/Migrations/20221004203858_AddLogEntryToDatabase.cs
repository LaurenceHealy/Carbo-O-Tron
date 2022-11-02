using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiabetesWebApp.Migrations
{
    public partial class AddLogEntryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logEntries",
                columns: table => new
                {
                    entryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    entryBg = table.Column<int>(type: "int", nullable: false),
                    entryCarb = table.Column<int>(type: "int", nullable: true),
                    entryInsulin = table.Column<double>(type: "float", nullable: false),
                    entryNote = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logEntries", x => x.entryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logEntries");
        }
    }
}
