using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleWine.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoValorPromocao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Promocao",
                table: "Vinhos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Vinhos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Promocao",
                table: "Vinhos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Vinhos");
        }
    }
}
