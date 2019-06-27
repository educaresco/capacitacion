using Microsoft.EntityFrameworkCore.Migrations;

namespace Viacash.General.Api.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SendersWB",
                columns: table => new
                {
                    ID_SENDER = table.Column<int>(nullable: false),
                    ID_BRANCH = table.Column<string>(nullable: false),
                    SEN_FNAME = table.Column<string>(nullable: true),
                    SEN_LNAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendersWB", x => new { x.ID_SENDER, x.ID_BRANCH });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendersWB");
        }
    }
}
