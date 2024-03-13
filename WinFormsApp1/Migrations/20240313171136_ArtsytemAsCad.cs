using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class ArtsytemAsCad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLICLINID_CLI",
                table: "Conexoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "CONCCLICLINID_CLI",
                table: "Conexoes",
                newName: "CONCCLIENTNID_ENT");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_CONCCLICLINID_CLI",
                table: "Conexoes",
                newName: "IX_Conexoes_CONCCLIENTNID_ENT");

            migrationBuilder.RenameColumn(
                name: "CLICRZS",
                table: "Clientes",
                newName: "ENTCUSUCAD");

            migrationBuilder.RenameColumn(
                name: "CLICDES",
                table: "Clientes",
                newName: "ENTCUSUALT");

            migrationBuilder.RenameColumn(
                name: "CLICCNPJ",
                table: "Clientes",
                newName: "ENTCNOMENT");

            migrationBuilder.RenameColumn(
                name: "CLICAPE",
                table: "Clientes",
                newName: "ENTCE_MAIL");

            migrationBuilder.RenameColumn(
                name: "CLINID_CLI",
                table: "Clientes",
                newName: "ENTNID_CEP");

            migrationBuilder.AlterColumn<int>(
                name: "ENTNID_CEP",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ENTNID_ENT",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ENTCAPELID",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ENTCCODCPF",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ENTCCOD_RG",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ENTCENDCOM",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ENTCTIPPES",
                table: "Clientes",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ENTDDATALT",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ENTDDATCAD",
                table: "Clientes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ENTNENDNUM",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ENTNID_ENT");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLIENTNID_ENT",
                table: "Conexoes",
                column: "CONCCLIENTNID_ENT",
                principalTable: "Clientes",
                principalColumn: "ENTNID_ENT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLIENTNID_ENT",
                table: "Conexoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTNID_ENT",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTCAPELID",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTCCODCPF",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTCCOD_RG",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTCENDCOM",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTCTIPPES",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTDDATALT",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTDDATCAD",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ENTNENDNUM",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "CONCCLIENTNID_ENT",
                table: "Conexoes",
                newName: "CONCCLICLINID_CLI");

            migrationBuilder.RenameIndex(
                name: "IX_Conexoes_CONCCLIENTNID_ENT",
                table: "Conexoes",
                newName: "IX_Conexoes_CONCCLICLINID_CLI");

            migrationBuilder.RenameColumn(
                name: "ENTNID_CEP",
                table: "Clientes",
                newName: "CLINID_CLI");

            migrationBuilder.RenameColumn(
                name: "ENTCUSUCAD",
                table: "Clientes",
                newName: "CLICRZS");

            migrationBuilder.RenameColumn(
                name: "ENTCUSUALT",
                table: "Clientes",
                newName: "CLICDES");

            migrationBuilder.RenameColumn(
                name: "ENTCNOMENT",
                table: "Clientes",
                newName: "CLICCNPJ");

            migrationBuilder.RenameColumn(
                name: "ENTCE_MAIL",
                table: "Clientes",
                newName: "CLICAPE");

            migrationBuilder.AlterColumn<int>(
                name: "CLINID_CLI",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "CLINID_CLI");

            migrationBuilder.AddForeignKey(
                name: "FK_Conexoes_Clientes_CONCCLICLINID_CLI",
                table: "Conexoes",
                column: "CONCCLICLINID_CLI",
                principalTable: "Clientes",
                principalColumn: "CLINID_CLI");
        }
    }
}
