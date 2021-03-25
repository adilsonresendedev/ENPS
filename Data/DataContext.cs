using ENPS.Models;
using Microsoft.EntityFrameworkCore;

namespace ENPS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NPS_votacao>(x => x.HasKey(y => new { y.nPS_PesquisaId, y.cAD_pessoaId }));
            modelBuilder.Entity<CAD_empresaCAD_email>(x => x.HasKey(y => new { y.CAD_empresaId, y.CAD_emailId }));
            modelBuilder.Entity<CAD_empresaCAD_endereco>(x => x.HasKey(y => new { y.CAD_empresaId, y.CAD_enderecoId }));
            modelBuilder.Entity<CAD_empresaCAD_telefone>(x => x.HasKey(y => new { y.CAD_empresaId, y.CAD_telefoneId }));
            modelBuilder.Entity<CAD_pessoaCAD_email>(x => x.HasKey(y => new { y.CAD_pessoaId, y.CAD_emailId }));
            modelBuilder.Entity<CAD_pessoaCAD_endereco>(x => x.HasKey(y => new { y.CAD_pessoaId, y.CAD_enderecoId }));
            modelBuilder.Entity<CAD_pessoaCAD_redeSocial>(x => x.HasKey(y => new { y.CAD_pessoaId, y.CAD_RedeSocialId }));
            modelBuilder.Entity<CAD_pessoaCAD_telefone>(x => x.HasKey(y => new { y.CAD_pessoaId, y.CAD_telefone_id }));
        }

        public DbSet<CAD_CNPJ> CAD_CNPJ { get; set; }
        public DbSet<CAD_CPF> CAD_CPF { get; set; }
        public DbSet<CAD_email> CAD_Email { get; set; }
        public DbSet<CAD_empresa> CAD_Empresa { get; set; }
        public DbSet<CAD_empresaCAD_email> CAD_empresaCAD_email { get; set; }
        public DbSet<CAD_empresaCAD_endereco> CAD_empresaCAD_Endereco { get; set; }
        public DbSet<CAD_empresa> CAD_EmpresaCAD_telefone { get; set; }
        public DbSet<CAD_endereco> CAD_endereco { get; set; }
        public DbSet<CAD_pessoa> CAD_Pessoa { get; set; }
        public DbSet<CAD_pessoaCAD_email> CAD_pessoaCAD_email { get; set; }
        public DbSet<CAD_pessoaCAD_endereco> CAD_pessoaCAD_endereco { get; set; }
        public DbSet<CAD_pessoaCAD_redeSocial> CAD_pessoaCAD_redeSocial { get; set; }
        public DbSet<CAD_pessoaCAD_telefone> CAD_pessoaCAD_telefone { get; set; }
        public DbSet<CAD_redeSocial> CAD_redeSocial { get; set; }
        public DbSet<CAD_Telefone> CAD_Telefone { get; set; }
        public DbSet<CAD_Usuario> CAD_usuario { get; set; }
        public DbSet<COF_Estado> COF_Estado { get; set; }
        public DbSet<COF_Cidade> COF_Cidade { get; set; }
        public DbSet<COF_pais> COF_pais { get; set; }
        public DbSet<NPS_Pesquisa> NPS_Pesquisa { get; set; }
        public DbSet<NPS_votacao> NPS_votacao { get; set; }

    }
}

