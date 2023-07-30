using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class createstatusentradasaida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Saida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Entrada",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Saida");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Entrada");
        }
    }
}
