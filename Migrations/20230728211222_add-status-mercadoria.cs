﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LEKSupply.Migrations
{
    /// <inheritdoc />
    public partial class addstatusmercadoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Mercadoria",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Mercadoria");
        }
    }
}
