using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENPS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAD_CNPJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_CNPJ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAD_CPF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_CPF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COF_Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COF_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COF_Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COF_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COF_pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COF_pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAD_Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cAD_UsuarioId = table.Column<int>(type: "int", nullable: true),
                    cAD_CNPJId = table.Column<int>(type: "int", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoId = table.Column<int>(type: "int", nullable: true),
                    cidadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Empresa_CAD_CNPJ_cAD_CNPJId",
                        column: x => x.cAD_CNPJId,
                        principalTable: "CAD_CNPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Empresa_COF_Cidade_cidadeId",
                        column: x => x.cidadeId,
                        principalTable: "COF_Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Empresa_COF_Estado_estadoId",
                        column: x => x.estadoId,
                        principalTable: "COF_Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Princial = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Email_CAD_Empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Principal = table.Column<bool>(type: "bit", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cOF_EstadoId = table.Column<int>(type: "int", nullable: true),
                    cOF_CidadeId = table.Column<int>(type: "int", nullable: true),
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Endereco_CAD_Empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Endereco_COF_Cidade_cOF_CidadeId",
                        column: x => x.cOF_CidadeId,
                        principalTable: "COF_Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Endereco_COF_Estado_cOF_EstadoId",
                        column: x => x.cOF_EstadoId,
                        principalTable: "COF_Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NPS_Pesquisa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: true),
                    IdOperador = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaMinima = table.Column<int>(type: "int", nullable: false),
                    NotaMaxima = table.Column<int>(type: "int", nullable: false),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFechamento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPS_Pesquisa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NPS_Pesquisa_CAD_Empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_EnderecoId = table.Column<int>(type: "int", nullable: true),
                    ETipoPessoa = table.Column<int>(type: "int", nullable: false),
                    CAD_CNPJId = table.Column<int>(type: "int", nullable: true),
                    CAD_CPFId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Pessoa_CAD_CNPJ_CAD_CNPJId",
                        column: x => x.CAD_CNPJId,
                        principalTable: "CAD_CNPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Pessoa_CAD_CPF_CAD_CPFId",
                        column: x => x.CAD_CPFId,
                        principalTable: "CAD_CPF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Pessoa_CAD_Endereco_CAD_EnderecoId",
                        column: x => x.CAD_EnderecoId,
                        principalTable: "CAD_Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_RedeSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ERedeSocial = table.Column<int>(type: "int", nullable: false),
                    LinkRedeSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_RedeSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_RedeSocial_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_Telefone",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Princial = table.Column<bool>(type: "bit", nullable: false),
                    CodigoPais = table.Column<int>(type: "int", nullable: false),
                    CodigoEstado = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: true),
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Telefone_CAD_Empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Telefone_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenhaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SenhaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: true),
                    CAD_emailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_usuario_CAD_Email_CAD_emailId",
                        column: x => x.CAD_emailId,
                        principalTable: "CAD_Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_usuario_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NPS_votacao",
                columns: table => new
                {
                    cAD_pessoaId = table.Column<int>(type: "int", nullable: false),
                    nPS_PesquisaId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    LinkVotacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPS_votacao", x => new { x.nPS_PesquisaId, x.cAD_pessoaId });
                    table.ForeignKey(
                        name: "FK_NPS_votacao_CAD_Pessoa_cAD_pessoaId",
                        column: x => x.cAD_pessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPS_votacao_NPS_Pesquisa_nPS_PesquisaId",
                        column: x => x.nPS_PesquisaId,
                        principalTable: "NPS_Pesquisa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Email_CAD_EmpresaId",
                table: "CAD_Email",
                column: "CAD_EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Empresa_cAD_CNPJId",
                table: "CAD_Empresa",
                column: "cAD_CNPJId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Empresa_cAD_UsuarioId",
                table: "CAD_Empresa",
                column: "cAD_UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Empresa_cidadeId",
                table: "CAD_Empresa",
                column: "cidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Empresa_estadoId",
                table: "CAD_Empresa",
                column: "estadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Endereco_CAD_EmpresaId",
                table: "CAD_Endereco",
                column: "CAD_EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Endereco_cOF_CidadeId",
                table: "CAD_Endereco",
                column: "cOF_CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Endereco_cOF_EstadoId",
                table: "CAD_Endereco",
                column: "cOF_EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Pessoa_CAD_CNPJId",
                table: "CAD_Pessoa",
                column: "CAD_CNPJId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Pessoa_CAD_CPFId",
                table: "CAD_Pessoa",
                column: "CAD_CPFId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Pessoa_CAD_EnderecoId",
                table: "CAD_Pessoa",
                column: "CAD_EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RedeSocial_CAD_PessoaId",
                table: "CAD_RedeSocial",
                column: "CAD_PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Telefone_CAD_EmpresaId",
                table: "CAD_Telefone",
                column: "CAD_EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Telefone_CAD_PessoaId",
                table: "CAD_Telefone",
                column: "CAD_PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_usuario_CAD_emailId",
                table: "CAD_usuario",
                column: "CAD_emailId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_usuario_CAD_PessoaId",
                table: "CAD_usuario",
                column: "CAD_PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_NPS_Pesquisa_CAD_EmpresaId",
                table: "NPS_Pesquisa",
                column: "CAD_EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_NPS_votacao_cAD_pessoaId",
                table: "NPS_votacao",
                column: "cAD_pessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_Empresa_CAD_usuario_cAD_UsuarioId",
                table: "CAD_Empresa",
                column: "cAD_UsuarioId",
                principalTable: "CAD_usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_Email_CAD_Empresa_CAD_EmpresaId",
                table: "CAD_Email");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_Endereco_CAD_Empresa_CAD_EmpresaId",
                table: "CAD_Endereco");

            migrationBuilder.DropTable(
                name: "CAD_RedeSocial");

            migrationBuilder.DropTable(
                name: "CAD_Telefone");

            migrationBuilder.DropTable(
                name: "COF_pais");

            migrationBuilder.DropTable(
                name: "NPS_votacao");

            migrationBuilder.DropTable(
                name: "NPS_Pesquisa");

            migrationBuilder.DropTable(
                name: "CAD_Empresa");

            migrationBuilder.DropTable(
                name: "CAD_usuario");

            migrationBuilder.DropTable(
                name: "CAD_Email");

            migrationBuilder.DropTable(
                name: "CAD_Pessoa");

            migrationBuilder.DropTable(
                name: "CAD_CNPJ");

            migrationBuilder.DropTable(
                name: "CAD_CPF");

            migrationBuilder.DropTable(
                name: "CAD_Endereco");

            migrationBuilder.DropTable(
                name: "COF_Cidade");

            migrationBuilder.DropTable(
                name: "COF_Estado");
        }
    }
}
