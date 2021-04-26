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
        }

        public DbSet<CAD_empresa> CAD_Empresa { get; set; }
        public DbSet<CAD_empresa> CAD_EmpresaCAD_telefone { get; set; }
        public DbSet<CAD_endereco> CAD_endereco { get; set; }
        public DbSet<CAD_pessoa> CAD_Pessoa { get; set; }
        public DbSet<CAD_redeSocial> CAD_redeSocial { get; set; }
        public DbSet<CAD_telefone> CAD_Telefone { get; set; }
        public DbSet<CAD_Usuario> CAD_usuario { get; set; }
        public DbSet<COF_estado> COF_Estado { get; set; }
        public DbSet<COF_cidade> COF_Cidade { get; set; }
        public DbSet<COF_pais> COF_pais { get; set; }
        public DbSet<NPS_pesquisa> NPS_Pesquisa { get; set; }
        public DbSet<NPS_votacao> NPS_votacao { get; set; }

    }
}

