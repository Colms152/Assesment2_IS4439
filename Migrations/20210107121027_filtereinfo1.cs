using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventchain.Migrations
{
    public partial class filtereinfo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EventInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "EventInfo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
