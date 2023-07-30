using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class refactordbcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Entrada",
                keyColumn: "Local",
                keyValue: null,
                column: "Local",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Local",
                table: "Entrada",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Mercadoria",
                columns: new[] { "Id", "Codigo", "Descricao", "Fabricante", "Nome", "Status", "Tipo" },
                values: new object[,]
                {
                    { 1, "d3a148b7-9fcd-4ed9-b01f-60dea40f17f8", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Mouse", "A", "Eletrônicos" },
                    { 2, "04eb22a0-ad54-4ee9-ab2f-42551d04bb74", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Teclado", "A", "Eletrônicos" },
                    { 3, "14f5ccad-5478-4546-81f6-28f2ad6e23ca", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Fone de ouvido", "A", "Eletrônicos" },
                    { 4, "63e27362-3390-437c-b1c8-f18bcde557cf", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Leader", "Camiseta", "A", "Roupas" },
                    { 5, "88dc33af-e8d2-47e3-957c-a6a6e50f9956", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Leader", "Bermuda", "A", "Roupas" },
                    { 6, "b7f732c0-f7f9-4f87-bf0a-f74d666c8e3a", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Leader", "Blusa", "A", "Roupas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Local",
                table: "Entrada",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
