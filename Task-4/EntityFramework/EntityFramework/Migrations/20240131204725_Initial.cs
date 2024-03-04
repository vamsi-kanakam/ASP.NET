using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerformingActs",
                columns: table => new
                {
                    PerformingActId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPerformers = table.Column<int>(type: "int", nullable: false),
                    Manager = table.Column<int>(type: "int", nullable: false),
                    PerformerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageAttendance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformingActs", x => x.PerformingActId);
                });

            migrationBuilder.CreateTable(
                name: "ProductionCompany",
                columns: table => new
                {
                    ProductionCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionCompany", x => x.ProductionCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueId);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentAttendance = table.Column<double>(type: "float", nullable: false),
                    TicketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: true),
                    PerformingActId = table.Column<int>(type: "int", nullable: true),
                    ProductionCompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_PerformingActs_PerformingActId",
                        column: x => x.PerformingActId,
                        principalTable: "PerformingActs",
                        principalColumn: "PerformingActId");
                    table.ForeignKey(
                        name: "FK_Event_ProductionCompany_ProductionCompanyId",
                        column: x => x.ProductionCompanyId,
                        principalTable: "ProductionCompany",
                        principalColumn: "ProductionCompanyId");
                    table.ForeignKey(
                        name: "FK_Event_Venue_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venue",
                        principalColumn: "VenueId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_PerformingActId",
                table: "Event",
                column: "PerformingActId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ProductionCompanyId",
                table: "Event",
                column: "ProductionCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_VenueId",
                table: "Event",
                column: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "PerformingActs");

            migrationBuilder.DropTable(
                name: "ProductionCompany");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}
