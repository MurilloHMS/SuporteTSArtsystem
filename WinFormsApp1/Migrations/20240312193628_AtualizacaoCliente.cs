using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_ClienteCLINID_CLI",
                table: "Conexoes");

            migrationBuilder.RenameColumn(
                name: "ClienteCLINID_CLI",
                table: "Conexoes",
                newName: "CONNID_CLICLINID_CLI");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_ClienteCLINID_CLI",
                table: "Conexoes",
                newName: "IX_Conexoes_CONNID_CLICLINID_CLI");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_CONNID_CLICLINID_CLI",
                table: "Conexoes",
                column: "CONNID_CLICLINID_CLI",
                principalTable: "Clientes",
                principalColumn: "CLINID_CLI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_CONNID_CLICLINID_CLI",
                table: "Conexoes");

            migrationBuilder.RenameColumn(
                name: "CONNID_CLICLINID_CLI",
                table: "Conexoes",
                newName: "ClienteCLINID_CLI");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_CONNID_CLICLINID_CLI",
                table: "Conexoes",
                newName: "IX_Conexoes_ClienteCLINID_CLI");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_ClienteCLINID_CLI",
                table: "Conexoes",
                column: "ClienteCLINID_CLI",
                principalTable: "Clientes",
                principalColumn: "CLINID_CLI");
        }
    }
}
