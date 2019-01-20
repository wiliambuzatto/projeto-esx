using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ESX.Teste.Infra.Data.Migrations
{
    public partial class Ajustes5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Patrimonios",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Marcas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "NEWID()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Patrimonios",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Marcas",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid));
        }
    }
}
