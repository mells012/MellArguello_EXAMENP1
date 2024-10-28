using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellArguello_EXAMENP1.Migrations
{
    /// <inheritdoc />
    public partial class version1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MA_Burger",
                columns: table => new
                {
                    MA_Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MA_Id = table.Column<int>(type: "int", nullable: false),
                    MA_ConsumidorFinal = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
                    MA_Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MA_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OtraFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MA_Burger", x => x.MA_Nombre);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MA_Burger");
        }
    }
}
