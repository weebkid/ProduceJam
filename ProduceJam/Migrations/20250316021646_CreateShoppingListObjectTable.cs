using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProduceJam.Migrations
{
    /// <inheritdoc />
    public partial class CreateShoppingListObjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Items",
                table: "ShoppingListObject",
                newName: "Commodity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Commodity",
                table: "ShoppingListObject",
                newName: "Items");
        }
    }
}
