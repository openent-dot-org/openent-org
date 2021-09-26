using Microsoft.EntityFrameworkCore.Migrations;

namespace ECNcloud.Migrations
{
    public partial class Initialcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Userkey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: true),
                    Subdirectory = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userkey", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Userkey",
                columns: new[] { "Id", "DisplayName", "Key", "Subdirectory" },
                values: new object[] { 1, "Test account", "FDC7D9355A9A1F080C05FCE3BBBE30A64974BEBD843CBD14", "56D79BBB857BEEA73A0376A2539059212F4A579D0050E10A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userkey");
        }
    }
}
