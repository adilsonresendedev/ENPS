﻿// <auto-generated />
using System;
using ENPS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ENPS.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAD_TelefoneCAD_empresa", b =>
                {
                    b.Property<int>("CAD_EmpresaId")
                        .HasColumnType("int");

                    b.Property<long>("CAD_telefoneId")
                        .HasColumnType("bigint");

                    b.HasKey("CAD_EmpresaId", "CAD_telefoneId");

                    b.HasIndex("CAD_telefoneId");

                    b.ToTable("CAD_TelefoneCAD_empresa");
                });

            modelBuilder.Entity("CAD_TelefoneCAD_pessoa", b =>
                {
                    b.Property<int>("CAD_PessoaId")
                        .HasColumnType("int");

                    b.Property<long>("CAD_TelefoneId")
                        .HasColumnType("bigint");

                    b.HasKey("CAD_PessoaId", "CAD_TelefoneId");

                    b.HasIndex("CAD_TelefoneId");

                    b.ToTable("CAD_TelefoneCAD_pessoa");
                });

            modelBuilder.Entity("CAD_UsuarioCAD_empresa", b =>
                {
                    b.Property<int>("CAD_UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("CAD_empresaId")
                        .HasColumnType("int");

                    b.HasKey("CAD_UsuarioId", "CAD_empresaId");

                    b.HasIndex("CAD_empresaId");

                    b.ToTable("CAD_UsuarioCAD_empresa");
                });

            modelBuilder.Entity("CAD_empresaCAD_endereco", b =>
                {
                    b.Property<int>("CAD_EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("CAD_enderedoId")
                        .HasColumnType("int");

                    b.HasKey("CAD_EmpresaId", "CAD_enderedoId");

                    b.HasIndex("CAD_enderedoId");

                    b.ToTable("CAD_empresaCAD_endereco");
                });

            modelBuilder.Entity("CAD_empresaCAD_redeSocial", b =>
                {
                    b.Property<int>("CAD_empresaId")
                        .HasColumnType("int");

                    b.Property<int>("CAD_redeSocialId")
                        .HasColumnType("int");

                    b.HasKey("CAD_empresaId", "CAD_redeSocialId");

                    b.HasIndex("CAD_redeSocialId");

                    b.ToTable("CAD_empresaCAD_redeSocial");
                });

            modelBuilder.Entity("CAD_enderecoCAD_pessoa", b =>
                {
                    b.Property<int>("CAD_EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("CAD_PessoaId")
                        .HasColumnType("int");

                    b.HasKey("CAD_EnderecoId", "CAD_PessoaId");

                    b.HasIndex("CAD_PessoaId");

                    b.ToTable("CAD_enderecoCAD_pessoa");
                });

            modelBuilder.Entity("CAD_pessoaCAD_redeSocial", b =>
                {
                    b.Property<int>("CAD_PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("CAD_RedeSocialId")
                        .HasColumnType("int");

                    b.HasKey("CAD_PessoaId", "CAD_RedeSocialId");

                    b.HasIndex("CAD_RedeSocialId");

                    b.ToTable("CAD_pessoaCAD_redeSocial");
                });

            modelBuilder.Entity("ENPS.Models.CAD_Telefone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CodigoEstado")
                        .HasColumnType("int");

                    b.Property<int>("CodigoPais")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<bool>("Princial")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CAD_Telefone");
                });

            modelBuilder.Entity("ENPS.Models.CAD_Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("CAD_pessoaId")
                        .HasColumnType("int");

                    b.Property<byte[]>("SenhaHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CAD_pessoaId");

                    b.ToTable("CAD_usuario");
                });

            modelBuilder.Entity("ENPS.Models.CAD_empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CAD_CNPJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CAD_empresa");
                });

            modelBuilder.Entity("ENPS.Models.CAD_endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("COF_CidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("COF_EstadoId")
                        .HasColumnType("int");

                    b.Property<int?>("COF_paisId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Principal")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("COF_CidadeId");

                    b.HasIndex("COF_EstadoId");

                    b.HasIndex("COF_paisId");

                    b.ToTable("CAD_endereco");
                });

            modelBuilder.Entity("ENPS.Models.CAD_pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CAD_CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NPS_PesquisaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NPS_PesquisaId");

                    b.ToTable("CAD_Pessoa");
                });

            modelBuilder.Entity("ENPS.Models.CAD_redeSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("ERedeSocial")
                        .HasColumnType("int");

                    b.Property<string>("LinkRedeSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CAD_redeSocial");
                });

            modelBuilder.Entity("ENPS.Models.COF_Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("COF_Cidade");
                });

            modelBuilder.Entity("ENPS.Models.COF_Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("COF_Estado");
                });

            modelBuilder.Entity("ENPS.Models.COF_pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("COF_pais");
                });

            modelBuilder.Entity("ENPS.Models.NPS_Pesquisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int?>("CAD_empresaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOperador")
                        .HasColumnType("int");

                    b.Property<int>("NotaMaxima")
                        .HasColumnType("int");

                    b.Property<int>("NotaMinima")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CAD_empresaId");

                    b.ToTable("NPS_Pesquisa");
                });

            modelBuilder.Entity("ENPS.Models.NPS_votacao", b =>
                {
                    b.Property<int>("nPS_PesquisaId")
                        .HasColumnType("int");

                    b.Property<int>("cAD_pessoaId")
                        .HasColumnType("int");

                    b.Property<string>("LinkVotacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("nPS_PesquisaId", "cAD_pessoaId");

                    b.HasIndex("cAD_pessoaId");

                    b.ToTable("NPS_votacao");
                });

            modelBuilder.Entity("CAD_TelefoneCAD_empresa", b =>
                {
                    b.HasOne("ENPS.Models.CAD_empresa", null)
                        .WithMany()
                        .HasForeignKey("CAD_EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_Telefone", null)
                        .WithMany()
                        .HasForeignKey("CAD_telefoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_TelefoneCAD_pessoa", b =>
                {
                    b.HasOne("ENPS.Models.CAD_pessoa", null)
                        .WithMany()
                        .HasForeignKey("CAD_PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_Telefone", null)
                        .WithMany()
                        .HasForeignKey("CAD_TelefoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_UsuarioCAD_empresa", b =>
                {
                    b.HasOne("ENPS.Models.CAD_Usuario", null)
                        .WithMany()
                        .HasForeignKey("CAD_UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_empresa", null)
                        .WithMany()
                        .HasForeignKey("CAD_empresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_empresaCAD_endereco", b =>
                {
                    b.HasOne("ENPS.Models.CAD_empresa", null)
                        .WithMany()
                        .HasForeignKey("CAD_EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_endereco", null)
                        .WithMany()
                        .HasForeignKey("CAD_enderedoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_empresaCAD_redeSocial", b =>
                {
                    b.HasOne("ENPS.Models.CAD_empresa", null)
                        .WithMany()
                        .HasForeignKey("CAD_empresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_redeSocial", null)
                        .WithMany()
                        .HasForeignKey("CAD_redeSocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_enderecoCAD_pessoa", b =>
                {
                    b.HasOne("ENPS.Models.CAD_endereco", null)
                        .WithMany()
                        .HasForeignKey("CAD_EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_pessoa", null)
                        .WithMany()
                        .HasForeignKey("CAD_PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAD_pessoaCAD_redeSocial", b =>
                {
                    b.HasOne("ENPS.Models.CAD_pessoa", null)
                        .WithMany()
                        .HasForeignKey("CAD_PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.CAD_redeSocial", null)
                        .WithMany()
                        .HasForeignKey("CAD_RedeSocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ENPS.Models.CAD_Usuario", b =>
                {
                    b.HasOne("ENPS.Models.CAD_pessoa", "CAD_pessoa")
                        .WithMany()
                        .HasForeignKey("CAD_pessoaId");

                    b.Navigation("CAD_pessoa");
                });

            modelBuilder.Entity("ENPS.Models.CAD_endereco", b =>
                {
                    b.HasOne("ENPS.Models.COF_Cidade", "COF_Cidade")
                        .WithMany()
                        .HasForeignKey("COF_CidadeId");

                    b.HasOne("ENPS.Models.COF_Estado", "COF_Estado")
                        .WithMany()
                        .HasForeignKey("COF_EstadoId");

                    b.HasOne("ENPS.Models.COF_pais", "COF_pais")
                        .WithMany()
                        .HasForeignKey("COF_paisId");

                    b.Navigation("COF_Cidade");

                    b.Navigation("COF_Estado");

                    b.Navigation("COF_pais");
                });

            modelBuilder.Entity("ENPS.Models.CAD_pessoa", b =>
                {
                    b.HasOne("ENPS.Models.NPS_Pesquisa", null)
                        .WithMany("CAD_pessoa")
                        .HasForeignKey("NPS_PesquisaId");
                });

            modelBuilder.Entity("ENPS.Models.NPS_Pesquisa", b =>
                {
                    b.HasOne("ENPS.Models.CAD_empresa", "CAD_empresa")
                        .WithMany()
                        .HasForeignKey("CAD_empresaId");

                    b.Navigation("CAD_empresa");
                });

            modelBuilder.Entity("ENPS.Models.NPS_votacao", b =>
                {
                    b.HasOne("ENPS.Models.CAD_pessoa", "CAD_Pessoa")
                        .WithMany("NPS_votacao")
                        .HasForeignKey("cAD_pessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENPS.Models.NPS_Pesquisa", "NPS_Pesquisa")
                        .WithMany("NPS_votacao")
                        .HasForeignKey("nPS_PesquisaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CAD_Pessoa");

                    b.Navigation("NPS_Pesquisa");
                });

            modelBuilder.Entity("ENPS.Models.CAD_pessoa", b =>
                {
                    b.Navigation("NPS_votacao");
                });

            modelBuilder.Entity("ENPS.Models.NPS_Pesquisa", b =>
                {
                    b.Navigation("CAD_pessoa");

                    b.Navigation("NPS_votacao");
                });
#pragma warning restore 612, 618
        }
    }
}
