using Microsoft.EntityFrameworkCore.Migrations;

namespace Eventchain.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "EventId1",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventId1",
                table: "Events",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TicketId",
                table: "Events",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Events_EventId1",
                table: "Events",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Tickets_TicketId",
                table: "Events",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Events_EventId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Tickets_TicketId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventId1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_TicketId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
