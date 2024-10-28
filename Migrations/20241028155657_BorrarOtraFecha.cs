using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MellArguello_EXAMENP1.Migrations
{
    /// <inheritdoc />
    public partial class BorrarOtraFecha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MA_Burger",
                table: "MA_Burger");

            migrationBuilder.AlterColumn<int>(
                name: "MA_Id",
                table: "MA_Burger",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "MA_Nombre",
                table: "MA_Burger",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MA_Burger",
                table: "MA_Burger",
                column: "MA_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MA_Burger",
                table: "MA_Burger");

            migrationBuilder.AlterColumn<string>(
                name: "MA_Nombre",
                table: "MA_Burger",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "MA_Id",
                table: "MA_Burger",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MA_Burger",
                table: "MA_Burger",
                column: "MA_Nombre");
        }
    }
}
