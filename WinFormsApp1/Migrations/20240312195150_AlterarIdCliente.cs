using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AlterarIdCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_CONNID_CLICLINID_CLI",
                table: "Conexoes");

            migrationBuilder.RenameColumn(
                name: "CONNID_CLICLINID_CLI",
                table: "Conexoes",
                newName: "CONCCLICLINID_CLI");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_CONNID_CLICLINID_CLI",
                table: "Conexoes",
                newName: "IX_Conexoes_CONCCLICLINID_CLI");

            migrationBuilder.AddColumn<int>(
                name: "CONNIDCLI",
                table: "Conexoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLICLINID_CLI",
                table: "Conexoes",
                column: "CONCCLICLINID_CLI",
                principalTable: "Clientes",
                principalColumn: "CLINID_CLI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLICLINID_CLI",
                table: "Conexoes");

            migrationBuilder.DropColumn(
                name: "CONNIDCLI",
                table: "Conexoes");

            migrationBuilder.RenameColumn(
                name: "CONCCLICLINID_CLI",
                table: "Conexoes",
                newName: "CONNID_CLICLINID_CLI");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_CONCCLICLINID_CLI",
                table: "Conexoes",
                newName: "IX_Conexoes_CONNID_CLICLINID_CLI");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_CONNID_CLICLINID_CLI",
                table: "Conexoes",
                column: "CONNID_CLICLINID_CLI",
                principalTable: "Clientes",
                principalColumn: "CLINID_CLI");
        }
    }
}
