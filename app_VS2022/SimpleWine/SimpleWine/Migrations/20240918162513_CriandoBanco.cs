using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleWine.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variedade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Safra = table.Column<int>(type: "int", nullable: false),
                    Maturacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graduacaoalcoolica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Produtor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinhos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vinhos");
        }
    }
}
