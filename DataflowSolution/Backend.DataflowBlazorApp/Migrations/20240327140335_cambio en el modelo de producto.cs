using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.DataflowBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class cambioenelmodelodeproducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoBarra",
                table: "product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoBarra",
                table: "product");
        }
    }
}
