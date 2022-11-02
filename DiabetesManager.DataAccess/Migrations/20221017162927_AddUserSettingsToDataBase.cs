using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiabetesWebApp.Migrations
{
    public partial class AddUserSettingsToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userSettings",
                columns: table => new
                {
                    settingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    targetBgl = table.Column<int>(type: "int", nullable: false),
                    lowBglAlert = table.Column<int>(type: "int", nullable: false),
                    insulinCorrectionFactor = table.Column<int>(type: "int", nullable: false),
                    carbRatio = table.Column<int>(type: "int", nullable: false),
                    insulinActionTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSettings", x => x.settingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userSettings");
        }
    }
}
