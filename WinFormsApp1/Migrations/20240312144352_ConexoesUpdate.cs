using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class ConexoesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CONCDES",
                table: "Conexoes",
                newName: "CONCUSRTS");

            migrationBuilder.AddColumn<string>(
                name: "CONCDESC",
                table: "Conexoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CONCSENART",
                table: "Conexoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CONCSENTS",
                table: "Conexoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CONCTIPCO",
                table: "Conexoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CONCUSRART",
                table: "Conexoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CONCDESC",
                table: "Conexoes");

            migrationBuilder.DropColumn(
                name: "CONCSENART",
                table: "Conexoes");

            migrationBuilder.DropColumn(
                name: "CONCSENTS",
                table: "Conexoes");

            migrationBuilder.DropColumn(
                name: "CONCTIPCO",
                table: "Conexoes");

            migrationBuilder.DropColumn(
                name: "CONCUSRART",
                table: "Conexoes");

            migrationBuilder.RenameColumn(
                name: "CONCUSRTS",
                table: "Conexoes",
                newName: "CONCDES");
        }
    }
}
