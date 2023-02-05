using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calculator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CountryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_TaxRules_VehicleExceptionRuleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleExceptionRuleId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleExceptionRuleId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TaxRules");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "PublicHolidays",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ISO = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extension = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ISO);
                });

            migrationBuilder.CreateTable(
                name: "TaxableTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endtime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxableTimes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "TaxableTimes");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "PublicHolidays");

            migrationBuilder.AddColumn<int>(
                name: "VehicleExceptionRuleId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TaxRules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CountryId",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleExceptionRuleId",
                table: "Vehicles",
                column: "VehicleExceptionRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_TaxRules_VehicleExceptionRuleId",
                table: "Vehicles",
                column: "VehicleExceptionRuleId",
                principalTable: "TaxRules",
                principalColumn: "Id");
        }
    }
}
