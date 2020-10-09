using Microsoft.EntityFrameworkCore.Migrations;

namespace Brainworks.UC.Data.Migrations
{
    public partial class CreatedTableOfFirstPrint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "about",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatisfactoryCustomer = table.Column<string>(type: "varchar(500 )", nullable: false),
                    Goal = table.Column<string>(type: "varchar(500 )", nullable: false),
                    Ahievement = table.Column<string>(type: "varchar(500 )", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "area",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pin = table.Column<string>(type: "varchar(6)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: true),
                    Subarea = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "firstPage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reference = table.Column<string>(type: "varchar(50)", nullable: false),
                    Key = table.Column<string>(type: "varchar(50)", nullable: false),
                    Value = table.Column<string>(type: "varchar(500 )", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firstPage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vendor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: false),
                    ShopName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Address = table.Column<string>(type: "varchar(50)", nullable: false),
                    Landmark = table.Column<string>(type: "varchar(50)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pin = table.Column<string>(type: "varchar(6)", nullable: false),
                    Mobile = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(25)", nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vendor_area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_vendor_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_vendor_service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_AreaId",
                table: "customers",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_AreaId",
                table: "vendor",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_CustomerId",
                table: "vendor",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_vendor_ServiceId",
                table: "vendor",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_area_AreaId",
                table: "customers",
                column: "AreaId",
                principalTable: "area",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_area_AreaId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "about");

            migrationBuilder.DropTable(
                name: "firstPage");

            migrationBuilder.DropTable(
                name: "vendor");

            migrationBuilder.DropTable(
                name: "area");

            migrationBuilder.DropIndex(
                name: "IX_customers_AreaId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "customers");
        }
    }
}
