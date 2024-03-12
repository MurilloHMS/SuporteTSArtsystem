using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class ClienteConexao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CLINID_CLI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLICRZS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLICAPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLICCNPJ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLICDES = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CLINID_CLI);
                });

            migrationBuilder.CreateTable(
                name: "Conexoes",
                columns: table => new
                {
                    CONNID_CON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONCTIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCDES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCIPCON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteCLINID_CLI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conexoes", x => x.CONNID_CON);
                    table.ForeignKey(
                        name: "FK_Conexoes_Clientes_ClienteCLINID_CLI",
                        column: x => x.ClienteCLINID_CLI,
                        principalTable: "Clientes",
                        principalColumn: "CLINID_CLI");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conexoes_ClienteCLINID_CLI",
                table: "Conexoes",
                column: "ClienteCLINID_CLI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conexoes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
