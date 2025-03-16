using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduceJam.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoredWeek1",
                columns: table => new
                {
                    Commodity = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    PapineCommonPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CorronationCommonPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CrossRoadsCommonPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoredWeek1");
        }
    }
}
