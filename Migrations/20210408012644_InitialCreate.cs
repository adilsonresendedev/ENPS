using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENPS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAD_empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Fantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAD_redeSocial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    ERedeSocial = table.Column<int>(type: "int", nullable: false),
                    LinkRedeSocial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_redeSocial", x => x.Id);
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
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Telefone", x => x.Id);
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
                name: "CAD_empresaCAD_redeSocial",
                columns: table => new
                {
                    CAD_empresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_redeSocialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_empresaCAD_redeSocial", x => new { x.CAD_empresaId, x.CAD_redeSocialId });
                    table.ForeignKey(
                        name: "FK_CAD_empresaCAD_redeSocial_CAD_empresa_CAD_empresaId",
                        column: x => x.CAD_empresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_empresaCAD_redeSocial_CAD_redeSocial_CAD_redeSocialId",
                        column: x => x.CAD_redeSocialId,
                        principalTable: "CAD_redeSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CAD_TelefoneCAD_empresa",
                columns: table => new
                {
                    CAD_EmpresaId = table.Column<int>(type: "int", nullable: false),
                    CAD_telefoneId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_TelefoneCAD_empresa", x => new { x.CAD_EmpresaId, x.CAD_telefoneId });
                    table.ForeignKey(
                        name: "FK_CAD_TelefoneCAD_empresa_CAD_empresa_CAD_EmpresaId",
                        column: x => x.CAD_EmpresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_TelefoneCAD_empresa_CAD_Telefone_CAD_telefoneId",
                        column: x => x.CAD_telefoneId,
                        principalTable: "CAD_Telefone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COF_EstadoId = table.Column<int>(type: "int", nullable: true),
                    COF_CidadeId = table.Column<int>(type: "int", nullable: true),
                    COF_paisId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_CAD_endereco_COF_pais_COF_paisId",
                        column: x => x.COF_paisId,
                        principalTable: "COF_pais",
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CAD_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPS_PesquisaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Pessoa_NPS_Pesquisa_NPS_PesquisaId",
                        column: x => x.NPS_PesquisaId,
                        principalTable: "NPS_Pesquisa",
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
                name: "CAD_pessoaCAD_redeSocial",
                columns: table => new
                {
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_RedeSocialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_pessoaCAD_redeSocial", x => new { x.CAD_PessoaId, x.CAD_RedeSocialId });
                    table.ForeignKey(
                        name: "FK_CAD_pessoaCAD_redeSocial_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_pessoaCAD_redeSocial_CAD_redeSocial_CAD_RedeSocialId",
                        column: x => x.CAD_RedeSocialId,
                        principalTable: "CAD_redeSocial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CAD_TelefoneCAD_pessoa",
                columns: table => new
                {
                    CAD_PessoaId = table.Column<int>(type: "int", nullable: false),
                    CAD_TelefoneId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_TelefoneCAD_pessoa", x => new { x.CAD_PessoaId, x.CAD_TelefoneId });
                    table.ForeignKey(
                        name: "FK_CAD_TelefoneCAD_pessoa_CAD_Pessoa_CAD_PessoaId",
                        column: x => x.CAD_PessoaId,
                        principalTable: "CAD_Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_TelefoneCAD_pessoa_CAD_Telefone_CAD_TelefoneId",
                        column: x => x.CAD_TelefoneId,
                        principalTable: "CAD_Telefone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CAD_usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    SenhaSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SenhaHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CAD_pessoaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_usuario_CAD_Pessoa_CAD_pessoaId",
                        column: x => x.CAD_pessoaId,
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

            migrationBuilder.CreateTable(
                name: "CAD_UsuarioCAD_empresa",
                columns: table => new
                {
                    CAD_UsuarioId = table.Column<int>(type: "int", nullable: false),
                    CAD_empresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD_UsuarioCAD_empresa", x => new { x.CAD_UsuarioId, x.CAD_empresaId });
                    table.ForeignKey(
                        name: "FK_CAD_UsuarioCAD_empresa_CAD_empresa_CAD_empresaId",
                        column: x => x.CAD_empresaId,
                        principalTable: "CAD_empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CAD_UsuarioCAD_empresa_CAD_usuario_CAD_UsuarioId",
                        column: x => x.CAD_UsuarioId,
                        principalTable: "CAD_usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresaCAD_endereco_CAD_enderedoId",
                table: "CAD_empresaCAD_endereco",
                column: "CAD_enderedoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_empresaCAD_redeSocial_CAD_redeSocialId",
                table: "CAD_empresaCAD_redeSocial",
                column: "CAD_redeSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_endereco_COF_CidadeId",
                table: "CAD_endereco",
                column: "COF_CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_endereco_COF_EstadoId",
                table: "CAD_endereco",
                column: "COF_EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_endereco_COF_paisId",
                table: "CAD_endereco",
                column: "COF_paisId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_enderecoCAD_pessoa_CAD_PessoaId",
                table: "CAD_enderecoCAD_pessoa",
                column: "CAD_PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_Pessoa_NPS_PesquisaId",
                table: "CAD_Pessoa",
                column: "NPS_PesquisaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_pessoaCAD_redeSocial_CAD_RedeSocialId",
                table: "CAD_pessoaCAD_redeSocial",
                column: "CAD_RedeSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_TelefoneCAD_empresa_CAD_telefoneId",
                table: "CAD_TelefoneCAD_empresa",
                column: "CAD_telefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_TelefoneCAD_pessoa_CAD_TelefoneId",
                table: "CAD_TelefoneCAD_pessoa",
                column: "CAD_TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_usuario_CAD_pessoaId",
                table: "CAD_usuario",
                column: "CAD_pessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_UsuarioCAD_empresa_CAD_empresaId",
                table: "CAD_UsuarioCAD_empresa",
                column: "CAD_empresaId");

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
                name: "CAD_empresaCAD_endereco");

            migrationBuilder.DropTable(
                name: "CAD_empresaCAD_redeSocial");

            migrationBuilder.DropTable(
                name: "CAD_enderecoCAD_pessoa");

            migrationBuilder.DropTable(
                name: "CAD_pessoaCAD_redeSocial");

            migrationBuilder.DropTable(
                name: "CAD_TelefoneCAD_empresa");

            migrationBuilder.DropTable(
                name: "CAD_TelefoneCAD_pessoa");

            migrationBuilder.DropTable(
                name: "CAD_UsuarioCAD_empresa");

            migrationBuilder.DropTable(
                name: "NPS_votacao");

            migrationBuilder.DropTable(
                name: "CAD_endereco");

            migrationBuilder.DropTable(
                name: "CAD_redeSocial");

            migrationBuilder.DropTable(
                name: "CAD_Telefone");

            migrationBuilder.DropTable(
                name: "CAD_usuario");

            migrationBuilder.DropTable(
                name: "COF_Cidade");

            migrationBuilder.DropTable(
                name: "COF_Estado");

            migrationBuilder.DropTable(
                name: "COF_pais");

            migrationBuilder.DropTable(
                name: "CAD_Pessoa");

            migrationBuilder.DropTable(
                name: "NPS_Pesquisa");

            migrationBuilder.DropTable(
                name: "CAD_empresa");
        }
    }
}
