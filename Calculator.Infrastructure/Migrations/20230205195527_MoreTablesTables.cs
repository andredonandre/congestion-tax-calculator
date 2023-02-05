using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calculator.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MoreTablesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "TaxRules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleExceptionRuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_TaxRules_VehicleExceptionRuleId",
                        column: x => x.VehicleExceptionRuleId,
                        principalTable: "TaxRules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleExceptionRuleId",
                table: "Vehicles",
                column: "VehicleExceptionRuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "TaxRules");
        }
    }
}
