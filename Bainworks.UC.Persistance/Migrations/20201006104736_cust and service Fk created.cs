using Microsoft.EntityFrameworkCore.Migrations;

namespace Brainworks.UC.Persistance.Migrations
{
    public partial class custandserviceFkcreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_customers_ServiceId",
                table: "customers",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_service_ServiceId",
                table: "customers",
                column: "ServiceId",
                principalTable: "service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_service_ServiceId",
                table: "customers");

            migrationBuilder.DropIndex(
                name: "IX_customers_ServiceId",
                table: "customers");
        }
    }
}
