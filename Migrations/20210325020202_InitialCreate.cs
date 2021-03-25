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
                name: "CAD_empresaCAD_email",
                columns: table => new
                {
                    CAD_empresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_emailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresaCAD_email", x => new { x.CAD_empresaId, x.CAD_emailId });
                });

            migrationBuilder.CreateTable(
                name: "CAD_empresaCAD_Endereco",
                columns: table => new
                {
                    CAD_empresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_enderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresaCAD_Endereco", x => new { x.CAD_empresaId, x.CAD_enderecoId });
                });

            migrationBuilder.CreateTable(
                name: "CAD_empresaCAD_telefone",
                columns: table => new
                {
                    CAD_empresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_telefoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresaCAD_telefone", x => new { x.CAD_empresaId, x.CAD_telefoneId });
                });

            migrationBuilder.CreateTable(
                name: "CAD_pessoaCAD_endereco",
                columns: table => new
                {
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_enderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_pessoaCAD_endereco", x => new { x.CAD_pessoaId, x.CAD_enderecoId });
                });

            migrationBuilder.CreateTable(
                name: "CAD_pessoaCAD_redeSocial",
                columns: table => new
                {
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_RedeSocialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_pessoaCAD_redeSocial", x => new { x.CAD_pessoaId, x.CAD_RedeSocialId });
                });

            migrationBuilder.CreateTable(
                name: "CAD_pessoaCAD_telefone",
                columns: table => new
                {
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_telefone_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_pessoaCAD_telefone", x => new { x.CAD_pessoaId, x.CAD_telefone_id });
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
                name: "CAD_Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_CPFId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenhaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SenhaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Pessoa_CAD_CPF_CAD_CPFId",
                        column: x => x.CAD_CPFId,
                        principalTable: "CAD_CPF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_endereco",
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
                    COF_EstadoId = table.Column<int>(type: "int", nullable: true),
                    COF_CidadeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_endereco_COF_Cidade_COF_CidadeId",
                        column: x => x.COF_CidadeId,
                        principalTable: "COF_Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_endereco_COF_Estado_COF_EstadoId",
                        column: x => x.COF_EstadoId,
                        principalTable: "COF_Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_CNPJId = table.Column<int>(type: "int", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COF_estadoId = table.Column<int>(type: "int", nullable: true),
                    COF_cidadeId = table.Column<int>(type: "int", nullable: true),
                    CAD_UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_empresa_CAD_CNPJ_CAD_CNPJId",
                        column: x => x.CAD_CNPJId,
                        principalTable: "CAD_CNPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_empresa_CAD_Pessoa_CAD_UsuarioId",
                        column: x => x.CAD_UsuarioId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_empresa_COF_Cidade_COF_cidadeId",
                        column: x => x.COF_cidadeId,
                        principalTable: "COF_Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_empresa_COF_Estado_COF_estadoId",
                        column: x => x.COF_estadoId,
                        principalTable: "COF_Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_redeSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ERedeSocial = table.Column<int>(type: "int", nullable: false),
                    LinkRedeSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_redeSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_redeSocial_CAD_Pessoa_CAD_pessoaId",
                        column: x => x.CAD_pessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_enderecoCAD_pessoa",
                columns: table => new
                {
                    CAD_EnderecoId = table.Column<int>(type: "int", nullable: false),
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_enderecoCAD_pessoa", x => new { x.CAD_EnderecoId, x.CAD_PessoaId });
                    table.ForeignKey(
                        name: "FK_CAD_enderecoCAD_pessoa_CAD_endereco_CAD_EnderecoId",
                        column: x => x.CAD_EnderecoId,
                        principalTable: "CAD_endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_enderecoCAD_pessoa_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CAD_empresaId = table.Column<int>(type: "int", nullable: true),
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Email_CAD_empresa_CAD_empresaId",
                        column: x => x.CAD_empresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Email_CAD_Pessoa_CAD_pessoaId",
                        column: x => x.CAD_pessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_empresaCAD_endereco",
                columns: table => new
                {
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_enderedoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresaCAD_endereco", x => new { x.CAD_EmpresaId, x.CAD_enderedoId });
                    table.ForeignKey(
                        name: "FK_CAD_empresaCAD_endereco_CAD_empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_empresaCAD_endereco_CAD_endereco_CAD_enderedoId",
                        column: x => x.CAD_enderedoId,
                        principalTable: "CAD_endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CAD_empresaId = table.Column<int>(type: "int", nullable: true),
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Telefone_CAD_empresa_CAD_empresaId",
                        column: x => x.CAD_empresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CAD_Telefone_CAD_Pessoa_CAD_pessoaId",
                        column: x => x.CAD_pessoaId,
                        principalTable: "CAD_Pessoa",
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
                    CAD_empresaId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_NPS_Pesquisa_CAD_empresa_CAD_empresaId",
                        column: x => x.CAD_empresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CAD_pessoaCAD_email",
                columns: table => new
                {
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_emailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_pessoaCAD_email", x => new { x.CAD_pessoaId, x.CAD_emailId });
                    table.ForeignKey(
                        name: "FK_CAD_pessoaCAD_email_CAD_Email_CAD_emailId",
                        column: x => x.CAD_emailId,
                        principalTable: "CAD_Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_pessoaCAD_email_CAD_Pessoa_CAD_pessoaId",
                        column: x => x.CAD_pessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_CAD_Email_CAD_empresaId",
                table: "CAD_Email",
                column: "CAD_empresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Email_CAD_pessoaId",
                table: "CAD_Email",
                column: "CAD_pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresa_CAD_CNPJId",
                table: "CAD_empresa",
                column: "CAD_CNPJId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresa_CAD_UsuarioId",
                table: "CAD_empresa",
                column: "CAD_UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresa_COF_cidadeId",
                table: "CAD_empresa",
                column: "COF_cidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresa_COF_estadoId",
                table: "CAD_empresa",
                column: "COF_estadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresaCAD_endereco_CAD_enderedoId",
                table: "CAD_empresaCAD_endereco",
                column: "CAD_enderedoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_endereco_COF_CidadeId",
                table: "CAD_endereco",
                column: "COF_CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_endereco_COF_EstadoId",
                table: "CAD_endereco",
                column: "COF_EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_enderecoCAD_pessoa_CAD_PessoaId",
                table: "CAD_enderecoCAD_pessoa",
                column: "CAD_PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Pessoa_CAD_CPFId",
                table: "CAD_Pessoa",
                column: "CAD_CPFId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_pessoaCAD_email_CAD_emailId",
                table: "CAD_pessoaCAD_email",
                column: "CAD_emailId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_redeSocial_CAD_pessoaId",
                table: "CAD_redeSocial",
                column: "CAD_pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Telefone_CAD_empresaId",
                table: "CAD_Telefone",
                column: "CAD_empresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Telefone_CAD_pessoaId",
                table: "CAD_Telefone",
                column: "CAD_pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_NPS_Pesquisa_CAD_empresaId",
                table: "NPS_Pesquisa",
                column: "CAD_empresaId");

            migrationBuilder.CreateIndex(
                name: "IX_NPS_votacao_cAD_pessoaId",
                table: "NPS_votacao",
                column: "cAD_pessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAD_empresaCAD_email");

            migrationBuilder.DropTable(
                name: "CAD_empresaCAD_endereco");

            migrationBuilder.DropTable(
                name: "CAD_empresaCAD_Endereco");

            migrationBuilder.DropTable(
                name: "CAD_empresaCAD_telefone");

            migrationBuilder.DropTable(
                name: "CAD_enderecoCAD_pessoa");

            migrationBuilder.DropTable(
                name: "CAD_pessoaCAD_email");

            migrationBuilder.DropTable(
                name: "CAD_pessoaCAD_endereco");

            migrationBuilder.DropTable(
                name: "CAD_pessoaCAD_redeSocial");

            migrationBuilder.DropTable(
                name: "CAD_pessoaCAD_telefone");

            migrationBuilder.DropTable(
                name: "CAD_redeSocial");

            migrationBuilder.DropTable(
                name: "CAD_Telefone");

            migrationBuilder.DropTable(
                name: "COF_pais");

            migrationBuilder.DropTable(
                name: "NPS_votacao");

            migrationBuilder.DropTable(
                name: "CAD_endereco");

            migrationBuilder.DropTable(
                name: "CAD_Email");

            migrationBuilder.DropTable(
                name: "NPS_Pesquisa");

            migrationBuilder.DropTable(
                name: "CAD_empresa");

            migrationBuilder.DropTable(
                name: "CAD_CNPJ");

            migrationBuilder.DropTable(
                name: "CAD_Pessoa");

            migrationBuilder.DropTable(
                name: "COF_Cidade");

            migrationBuilder.DropTable(
                name: "COF_Estado");

            migrationBuilder.DropTable(
                name: "CAD_CPF");
        }
    }
}
