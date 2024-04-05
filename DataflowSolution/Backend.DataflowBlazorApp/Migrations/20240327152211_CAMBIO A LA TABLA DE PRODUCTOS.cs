using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.DataflowBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class CAMBIOALATABLADEPRODUCTOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "ProductId");
        }
    }
}
