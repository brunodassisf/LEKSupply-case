using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addidEntradasaida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Saida");

            migrationBuilder.AddColumn<int>(
                name: "IdEntrada",
                table: "Saida",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEntrada",
                table: "Saida");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Saida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
