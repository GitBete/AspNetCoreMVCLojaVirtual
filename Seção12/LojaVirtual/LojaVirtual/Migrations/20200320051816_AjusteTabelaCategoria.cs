using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class AjusteTabelaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Categoria_CotegoriaPaiId",
                table: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_CotegoriaPaiId",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "CotegoriaPaiId",
                table: "Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaPaiId",
                table: "Categoria",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaPaiId",
                table: "Categoria",
                column: "CategoriaPaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Categoria_CategoriaPaiId",
                table: "Categoria",
                column: "CategoriaPaiId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Categoria_CategoriaPaiId",
                table: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_CategoriaPaiId",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "CategoriaPaiId",
                table: "Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "CotegoriaPaiId",
                table: "Categoria",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CotegoriaPaiId",
                table: "Categoria",
                column: "CotegoriaPaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Categoria_CotegoriaPaiId",
                table: "Categoria",
                column: "CotegoriaPaiId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
