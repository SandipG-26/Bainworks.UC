using Microsoft.EntityFrameworkCore.Migrations;

namespace Brainworks.UC.Persistance.Migrations
{
    public partial class CreatedTableforsecondandthirdsprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assign",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    City = table.Column<string>(type: "varchar(100 )", nullable: false),
                    StatusId = table.Column<string>(type: "varchar(100 )", nullable: false),
                    PinId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_assign_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assign_service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "billing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceCharge = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaterialCharge = table.Column<string>(type: "varchar(20)", nullable: false),
                    Total = table.Column<string>(type: "varchar(20)", nullable: false),
                    GST = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contactus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileNo = table.Column<string>(type: "varchar(12)", nullable: false),
                    Email = table.Column<string>(type: "varchar(20)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "feedback",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_feedback_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_feedback_vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "vendor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "complaint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complaint", x => x.Id);
                    table.ForeignKey(
                        name: "FK_complaint_customers_CityId",
                        column: x => x.CityId,
                        principalTable: "customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_complaint_assign_StatusId",
                        column: x => x.StatusId,
                        principalTable: "assign",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "completed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CustPinId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    assignId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_completed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_completed_customers_CustPinId",
                        column: x => x.CustPinId,
                        principalTable: "customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_completed_service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "service",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_completed_assign_assignId",
                        column: x => x.assignId,
                        principalTable: "assign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "newLead",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CityId = table.Column<string>(nullable: true),
                    CustPinId = table.Column<int>(nullable: false),
                    assignId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newLead", x => x.Id);
                    table.ForeignKey(
                        name: "FK_newLead_customers_CustPinId",
                        column: x => x.CustPinId,
                        principalTable: "customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_newLead_assign_assignId",
                        column: x => x.assignId,
                        principalTable: "assign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "replacement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_replacement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_replacement_customers_CityId",
                        column: x => x.CityId,
                        principalTable: "customers",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_replacement_assign_StatusId",
                        column: x => x.StatusId,
                        principalTable: "assign",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "due",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceChargeId = table.Column<int>(nullable: false),
                    MaterialChargeId = table.Column<int>(nullable: false),
                    TotalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_due", x => x.Id);
                    table.ForeignKey(
                        name: "FK_due_billing_TotalId",
                        column: x => x.TotalId,
                        principalTable: "billing",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_assign_CustomerId",
                table: "assign",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_assign_ServiceId",
                table: "assign",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_complaint_CityId",
                table: "complaint",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_complaint_StatusId",
                table: "complaint",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_completed_CustPinId",
                table: "completed",
                column: "CustPinId");

            migrationBuilder.CreateIndex(
                name: "IX_completed_ServiceId",
                table: "completed",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_completed_assignId",
                table: "completed",
                column: "assignId");

            migrationBuilder.CreateIndex(
                name: "IX_due_TotalId",
                table: "due",
                column: "TotalId");

            migrationBuilder.CreateIndex(
                name: "IX_feedback_CustomerId",
                table: "feedback",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_feedback_VendorId",
                table: "feedback",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_newLead_CustPinId",
                table: "newLead",
                column: "CustPinId");

            migrationBuilder.CreateIndex(
                name: "IX_newLead_assignId",
                table: "newLead",
                column: "assignId");

            migrationBuilder.CreateIndex(
                name: "IX_replacement_CityId",
                table: "replacement",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_replacement_StatusId",
                table: "replacement",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "complaint");

            migrationBuilder.DropTable(
                name: "completed");

            migrationBuilder.DropTable(
                name: "contactus");

            migrationBuilder.DropTable(
                name: "due");

            migrationBuilder.DropTable(
                name: "feedback");

            migrationBuilder.DropTable(
                name: "newLead");

            migrationBuilder.DropTable(
                name: "replacement");

            migrationBuilder.DropTable(
                name: "billing");

            migrationBuilder.DropTable(
                name: "assign");
        }
    }
}
