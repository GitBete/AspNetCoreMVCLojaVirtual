using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class AjusteClienteNumero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "logradouroNumr",
                table: "Clientes",
                newName: "LogradouroNumr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogradouroNumr",
                table: "Clientes",
                newName: "logradouroNumr");
        }
    }
}
