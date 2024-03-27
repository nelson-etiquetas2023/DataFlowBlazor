using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.DataflowBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class modificarloscamposdelatablaproducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsService",
                table: "product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "imagen",
                table: "product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "product");

            migrationBuilder.DropColumn(
                name: "IsService",
                table: "product");

            migrationBuilder.DropColumn(
                name: "imagen",
                table: "product");
        }
    }
}
