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

        public DbSet<CAD_Usuario> CAD_usuario { get; set; }
        public DbSet<CAD_Pessoa> CAD_Pessoa { get; set; }
        public DbSet<CAD_Endereco> CAD_Endereco { get; set; }
        public DbSet<CAD_Telefone> CAD_Telefone { get; set; }
        public DbSet<CAD_RedeSocial> CAD_RedeSocial { get; set; }
        public DbSet<CAD_CNPJ> CAD_CNPJ { get; set; }
        public DbSet<CAD_CPF> CAD_CPF { get; set; }
        public DbSet<CAD_email> CAD_Email { get; set; }
        public DbSet<CAD_Empresa> CAD_Empresa { get; set; }
        public DbSet<COF_Estado> COF_Estado { get; set; }
        public DbSet<COF_Cidade> COF_Cidade { get; set; }
        public DbSet<COF_pais> COF_pais { get; set; }
        public DbSet<NPS_Pesquisa> NPS_Pesquisa { get; set; }
        public DbSet<NPS_votacao> NPS_votacao { get; set; }

    }
}

