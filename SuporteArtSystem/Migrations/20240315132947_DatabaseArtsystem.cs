using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuporteArtSystem.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseArtsystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASENTENT",
                columns: table => new
                {
                    ENTNID_ENT = table.Column<int>(type: "int", nullable: false),
                    ENTNID_CEP = table.Column<int>(type: "int", nullable: false),
                    ENTCTIPPES = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ENTCCODCPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENTCCOD_RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTCNOMENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENTCAPELID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTNENDNUM = table.Column<int>(type: "int", nullable: false),
                    ENTCENDCOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTCE_MAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTCUSUCAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTDDATCAD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ENTCUSUALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENTDDATALT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASENTENT", x => new { x.ENTNID_ENT, x.ENTNID_CEP });
                });

            migrationBuilder.CreateTable(
                name: "ASENTENT_CON",
                columns: table => new
                {
                    CONNID_CON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CONCTIPCO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCDESC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCIPCON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCTIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCUSRTS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCSENTS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCUSRART = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONCSENART = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CONNIDCLI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASENTENT_CON", x => x.CONNID_CON);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASENTENT");

            migrationBuilder.DropTable(
                name: "ASENTENT_CON");
        }
    }
}
