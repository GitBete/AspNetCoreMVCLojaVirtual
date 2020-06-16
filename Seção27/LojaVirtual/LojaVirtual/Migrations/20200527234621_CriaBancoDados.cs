using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class CriaBancoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Slug = table.Column<string>(nullable: false),
                    CategoriaPaiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Categoria_CategoriaPaiId",
                        column: x => x.CategoriaPaiId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(maxLength: 10, nullable: false),
                    UF = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    LogradouroNumr = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: false),
                    Situacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterEmails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    Largura = table.Column<int>(nullable: false),
                    Altura = table.Column<int>(nullable: false),
                    Comprimento = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnderecosEntrega",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(maxLength: 10, nullable: false),
                    UF = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
                    Bairro = table.Column<string>(nullable: false),
                    Logradouro = table.Column<string>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    LogradouroNumr = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecosEntrega", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnderecosEntrega_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    FreteEmpresa = table.Column<string>(nullable: true),
                    FreteCodRastreamento = table.Column<string>(nullable: true),
                    FormaPagamento = table.Column<string>(nullable: true),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    DadosTransaction = table.Column<string>(nullable: true),
                    DadosProdutos = table.Column<string>(nullable: true),
                    DataRegistro = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    NFe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caminho = table.Column<string>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagem_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoSituacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<string>(nullable: true),
                    Dados = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoSituacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoSituacoes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaPaiId",
                table: "Categoria",
                column: "CategoriaPaiId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosEntrega_ClienteId",
                table: "EnderecosEntrega",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagem_ProdutoId",
                table: "Imagem",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoSituacoes_PedidoId",
                table: "PedidoSituacoes",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaboradores");

            migrationBuilder.DropTable(
                name: "EnderecosEntrega");

            migrationBuilder.DropTable(
                name: "Imagem");

            migrationBuilder.DropTable(
                name: "NewsletterEmails");

            migrationBuilder.DropTable(
                name: "PedidoSituacoes");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
