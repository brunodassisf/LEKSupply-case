using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addnovasmercadorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Entrada",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "df95ef1a-e596-4647-8f9c-0d9ecd5cde99");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "ee4bdc3c-5008-4296-8dcc-900c2e0ab603");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "782c0f98-0b8e-421b-b97e-3a4ad474ae57");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "d0d168a2-fe3e-4ca6-b72b-6b2593abaf1f");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "9b22dfa0-5915-4d9d-ad6e-f037f74b4e8d");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "77afdde1-c198-447b-b4a7-dc1807b50a4e");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "Codigo",
                value: "de441cad-c74b-41df-ad84-8262953928ee");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "Codigo",
                value: "0d4807b9-4175-4eb3-a077-297e3ba85f20");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "Codigo",
                value: "9fc5cf5c-6893-4dea-97fd-72ea5a47c120");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "Codigo",
                value: "5fbc6410-a651-49f8-accc-edb714752cff");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "Codigo",
                value: "2efa1455-3775-4475-b405-922c63817b88");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "Codigo",
                value: "7924e2b2-6008-48de-9c6d-30ec7158a33c");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "Codigo",
                value: "c9a3d3eb-a623-476b-ad52-a121b3697b96");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "Codigo",
                value: "9c785acf-ab08-44fd-9b3f-f6e9a2ef7bcd");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "Codigo",
                value: "894b23c3-834b-458c-98cc-8a3456aa4a1c");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "Codigo",
                value: "ee638f56-7250-413f-a020-80b2d654ca83");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "Codigo",
                value: "102ae8db-62c5-446a-a032-c572a7ad419c");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "Codigo",
                value: "057ae035-443e-404d-9467-e61d1b07aacd");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "Codigo",
                value: "349d8196-d4cb-45d7-a727-3bc7e3e1206e");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "Codigo",
                value: "023a9af9-60ef-4bc3-ad73-4b66f6c88492");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 21,
                column: "Codigo",
                value: "37d42d04-3e4a-417d-896a-2c49f107d4d4");

            migrationBuilder.InsertData(
                table: "Mercadoria",
                columns: new[] { "Id", "Codigo", "Descricao", "Fabricante", "Nome", "Status", "Tipo" },
                values: new object[,]
                {
                    { 22, "82c5e39e-aa05-4d2e-a9b2-a9db82d48740", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Fashion Clothing", "Camiseta Listrada", "A", "Roupas" },
                    { 23, "84449487-eab9-40ba-86be-6e276d40d8a1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "TechCom", "Smartphone Galaxy", "A", "Eletrônicos" },
                    { 24, "6a9afac4-cb96-4d44-ace1-e72b8f5dd5d3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "BrincaBem", "Carrinho de Controle Remoto", "A", "Brinquedos" },
                    { 25, "f685cab9-db61-4522-a789-59af2f724041", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Saboroso Foods", "Biscoitos Deliciosos", "A", "Alimentos" },
                    { 26, "00f8ae5b-4899-4368-a2b2-f02059a1bd9b", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "CasaNova Supplies", "Tinta para Parede", "A", "Materiais de construção" },
                    { 27, "b070a959-8860-41ba-a709-6eaf605bd10d", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "Fashion Deluxe", "Jaqueta de Couro", "A", "Roupas" },
                    { 28, "7fcaa9e7-8ec6-4170-83d2-5956a9cea554", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "TechGadgets", "Smartwatch Fitness", "A", "Eletrônicos" },
                    { 29, "94987283-9cf5-4592-b3dc-cd9649eb0440", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "DivertKids", "Quebra-Cabeça Colorido", "A", "Brinquedos" },
                    { 30, "b99dfe53-e468-442b-9316-dad02cffd197", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ", "SweetTreats", "Chocolate Cremoso", "A", "Alimentos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.InsertData(
                table: "Entrada",
                columns: new[] { "Id", "Data", "IdMercadoria", "Local", "Nome", "Quantidade", "Status" },
                values: new object[,]
                {
                    { 1, "2023-07-30 12:22:55", 1, "São Paulo", "Mouse", 100, "A" },
                    { 2, "2023-08-15 09:10:30", 2, "Rio de Janeiro", "Teclado", 80, "A" },
                    { 3, "2023-09-05 16:45:22", 3, "Minas Gerais", "Fone de ouvido", 120, "A" },
                    { 4, "2023-10-20 14:18:50", 4, "Bahia", "Camiseta", 200, "A" },
                    { 5, "2023-11-02 11:05:15", 5, "Santa Catarina", "Bermuda", 90, "A" },
                    { 6, "2023-12-12 08:30:40", 6, "Pará", "Blusa", 60, "A" },
                    { 7, "2024-01-08 17:55:10", 7, "Rio Grande do Sul", "Carrinho de corrrida", 40, "A" },
                    { 8, "2024-02-18 22:48:03", 8, "Acre", "Boneco de ação", 75, "A" },
                    { 9, "2024-03-29 19:37:27", 9, "Ceará", "Casinha de brinquedo", 110, "A" },
                    { 10, "2024-04-05 13:12:12", 10, "Distrito Federal", "Batatatinhas", 180, "A" }
                });

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "Codigo",
                value: "6bbbe257-ce27-4a3e-91ea-357516b487dc");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "Codigo",
                value: "7a30a76c-09b1-4220-b144-cb2d350d967f");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "Codigo",
                value: "de12fc2c-c377-4c77-b864-5bfe6fb8b45f");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "Codigo",
                value: "600b9073-dee3-418f-b837-20b8a33b2c5a");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "Codigo",
                value: "b60c6074-e5c9-417b-b9b9-684d782a21a0");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "Codigo",
                value: "81ee3deb-dfca-4799-aee5-4d295bc0b187");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 7,
                column: "Codigo",
                value: "8054edc8-f843-4d0f-aca0-c7376889ee04");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 8,
                column: "Codigo",
                value: "94401a2c-f360-47ae-beb0-3624f8349da4");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 9,
                column: "Codigo",
                value: "b4461156-0c81-41fd-bc0a-0ed929a6eb0e");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 10,
                column: "Codigo",
                value: "866772df-ec2c-4cd0-94ee-63cff632d4a6");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 11,
                column: "Codigo",
                value: "fe8a6a73-1c86-42ff-bdb8-501eb6800e2b");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 12,
                column: "Codigo",
                value: "3db3cfe2-853b-4201-b19a-7ac762faaf68");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 13,
                column: "Codigo",
                value: "2724db29-45a3-4ea1-b92d-2dd7996d4a27");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 14,
                column: "Codigo",
                value: "ea25e815-9de3-451d-a85b-584a88002444");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 15,
                column: "Codigo",
                value: "df5b4e58-c167-4363-b17c-f36cad1d0328");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 16,
                column: "Codigo",
                value: "f8cb6578-380a-45f9-804a-a9e978a9955e");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 17,
                column: "Codigo",
                value: "daf93dd6-a1c9-4a4c-9a59-63d811edc6be");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 18,
                column: "Codigo",
                value: "a988c3a2-e522-4964-b3ea-2cb13285bed7");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 19,
                column: "Codigo",
                value: "0e12e491-6a4e-444e-84c6-5ee077c5e702");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 20,
                column: "Codigo",
                value: "d1291b61-0f7c-456f-9b41-78efd4ec66f0");

            migrationBuilder.UpdateData(
                table: "Mercadoria",
                keyColumn: "Id",
                keyValue: 21,
                column: "Codigo",
                value: "86eb35e8-9b8b-4a5c-97ae-2c1de995d9d5");
        }
    }
}
