﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourOfHeroes.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    HeroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.HeroID);
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "HeroID", "Name" },
                values: new object[,]
                {
                    { 12, "Dr. Nice" },
                    { 13, "Bombasto" },
                    { 14, "Celeritas" },
                    { 15, "Magneta" },
                    { 16, "RubberMan" },
                    { 17, "Dynama" },
                    { 18, "Dr. IQ" },
                    { 19, "Magma" },
                    { 20, "Tornado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
