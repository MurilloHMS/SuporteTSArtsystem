using Microsoft.EntityFrameworkCore;

using SuporteArtSystem.Models;

namespace SuporteArtSystem.Databases
{
    internal class SuporteContext : DbContext
    {

        Settings setup = new Settings();

        private string _connectionString;
        
        public DbSet<ASENTENT> ASENTENT { get; set; }
        public DbSet<ASENTENT_CON> ASENTENT_CON { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Settings setup = new Settings();
            _connectionString = setup.ConnectionString;
            optionsBuilder
                .UseSqlServer(_connectionString)
                .UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASENTENT>()
                .HasKey(a => new { a.ENTNID_ENT, a.ENTNID_CEP });
        }

        public void CriarTabelaASENTENT_CON()
        {
            Database.ExecuteSqlRaw(@"
                CREATE TABLE ASENTENT_CON (
                    CONNID_CON INT NOT NULL IDENTITY(1,1),
                    CONCTIPCO NVARCHAR(100),
                    CONCDESC NVARCHAR(100),
                    CONCIPCON NVARCHAR(1000),
                    CONCTIP NVARCHAR(100),
                    CONCUSRTS NVARCHAR(100),
                    CONCSENTS NVARCHAR(100),
                    CONCUSRART NVARCHAR(100),
                    CONCSENART NVARCHAR(100),
                    CONNIDCLI INT NOT NULL,
                    CONSTRAINT PK_ASENTENT_CON PRIMARY KEY (CONNID_CON)
                );
            ");
        }
    }
}
