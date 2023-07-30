using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addnovasmercadoriastest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "fec3355a-a6d9-48cf-a0d6-1dd28e9ae26f");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "bf551478-2cc6-4f2e-b4a1-15fca0311cca");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "3d089885-e41f-4504-a8b2-fec6f18c9e19");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "5a46da48-abc4-4e49-82bd-ef922d66e608");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "61bd18c0-bd86-4dec-858e-eac8c281f6bb");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "1faa9222-1bf6-4fb0-9b8e-f6f97aa52db2");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "Codigo",
                value: "db5c069f-e816-4577-8f28-3f4492813ed7");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "Codigo",
                value: "d6ccbfc1-11be-422a-b6cc-f1f7e38631e6");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "Codigo",
                value: "4b745d70-bfd0-42f8-9f56-2584fa253d61");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "Codigo",
                value: "1cd7dcd2-4205-4cb7-810d-9a814d46a747");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "Codigo",
                value: "9364137a-8f25-4265-85cb-f4e417c40210");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "Codigo",
                value: "a406cafe-afa4-4b14-9502-5a8ddfc70c6c");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "Codigo",
                value: "02d3d52d-95bc-43ee-a4d1-df2d476ae786");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "Codigo",
                value: "8e68869d-b349-4989-804e-944c7cc5e084");

            migrationBuilder.InsertData(
                table: "Mercadoria",
                columns: new[] { "Id", "Codigo", "Descricao", "Fabricante", "Nome", "Status", "Tipo" },
                values: new object[,]
                {
                    { 15, "1ac1de3b-22c6-4566-b05a-577375d2f49c", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Gabinete desktop", "A", "Eletrônicos" },
                    { 16, "82006ad0-b9c6-40bb-bc6f-b4e0a02645df", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Microfone", "A", "Eletrônicos" },
                    { 17, "1c18de2d-d3e2-41d9-8c65-e74781505c16", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Monitor", "A", "Eletrônicos" },
                    { 18, "16705546-d645-4942-9b87-48b2e29cc733", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Processador intel", "A", "Eletrônicos" },
                    { 19, "b97a1305-0288-4792-9bf1-13133daa9965", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Dell", "Placa de video", "A", "Eletrônicos" },
                    { 20, "c083bc88-7a85-4477-bad0-5a32095307bd", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Leader", "Casado", "A", "Roupas" },
                    { 21, "3ee1c17e-e893-470e-bb78-c5da55ee59f5", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Leader", "Calça jeans", "A", "Roupas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 21);

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

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "Codigo",
                value: "16803e47-f2d8-453e-b4cf-9ee699f2a22e");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "Codigo",
                value: "f788f813-511f-40bf-b239-5464d88f52b0");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "Codigo",
                value: "5fd95085-f329-452b-a8a8-15d80f74ea35");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "Codigo",
                value: "b0ccf2b8-02eb-45d0-aef7-5b8ccfc23a56");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "Codigo",
                value: "8924d0c4-5b58-4abe-80b9-168393e59523");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "Codigo",
                value: "0530dc7b-e4dd-4d7b-bcf8-749e912b0fa1");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "Codigo",
                value: "29c7ed42-31b2-4d4e-b001-d99da52e59a9");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "Codigo",
                value: "11358381-7154-4743-89f4-21428fc15572");
        }
    }
}
