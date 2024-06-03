using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tangy_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductIt",
                table: "ProductPrices");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "ProductPrices",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductPrices",
                newName: "price");

            migrationBuilder.AddColumn<int>(
                name: "ProductIt",
                table: "ProductPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
