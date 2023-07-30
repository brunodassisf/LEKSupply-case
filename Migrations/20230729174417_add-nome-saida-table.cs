using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addnomesaidatable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Saida",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Saida");
        }
    }
}
