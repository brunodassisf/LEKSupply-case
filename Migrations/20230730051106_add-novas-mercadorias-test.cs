using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addnovasmercadoriastest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Saida",
                keyColumn: "Local",
                keyValue: null,
                column: "Local",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Local",
                table: "Saida",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "c38d0c3e-bc5a-4aa9-b5d2-5bf6e5988ae5");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "1ee6eef9-4f3f-4219-ac5b-78f3e083448f");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "bb0b9445-8a81-4d4e-bf84-58c73df4cac4");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "95fe3e3d-8ef4-4aa3-a897-7154ee77be44");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "0bb0de1b-a2da-4302-9b91-de9a2d9ab327");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "61fc0000-626d-4a00-8b5c-bca4b7d4fca7");

            migrationBuilder.InsertData(
                table: "Mercadoria",
                columns: new[] { "Id", "Codigo", "Descricao", "Fabricante", "Nome", "Status", "Tipo" },
                values: new object[,]
                {
                    { 7, "16803e47-f2d8-453e-b4cf-9ee699f2a22e", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Hasbro", "Carrinho de corrrida", "A", "Brinquedos" },
                    { 8, "f788f813-511f-40bf-b239-5464d88f52b0", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Hasbro", "Boneco de ação", "A", "Brinquedos" },
                    { 9, "5fd95085-f329-452b-a8a8-15d80f74ea35", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Hasbro", "Casinha de brinquedo", "A", "Brinquedos" },
                    { 10, "b0ccf2b8-02eb-45d0-aef7-5b8ccfc23a56", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Lays", "Batatatinhas", "A", "Alimentos" },
                    { 11, "8924d0c4-5b58-4abe-80b9-168393e59523", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Nestle", "kit kat", "A", "Alimentos" },
                    { 12, "0530dc7b-e4dd-4d7b-bcf8-749e912b0fa1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Lacta", "Sonho de Valsa", "A", "Alimentos" },
                    { 13, "29c7ed42-31b2-4d4e-b001-d99da52e59a9", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Philips", "Lampada", "A", "Materiais de construção" },
                    { 14, "11358381-7154-4743-89f4-21428fc15572", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Pial", "Tomada", "A", "Materiais de construção" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Local",
                table: "Saida",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "d3a148b7-9fcd-4ed9-b01f-60dea40f17f8");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "04eb22a0-ad54-4ee9-ab2f-42551d04bb74");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "14f5ccad-5478-4546-81f6-28f2ad6e23ca");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "63e27362-3390-437c-b1c8-f18bcde557cf");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "88dc33af-e8d2-47e3-957c-a6a6e50f9956");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "b7f732c0-f7f9-4f87-bf0a-f74d666c8e3a");
        }
    }
}
