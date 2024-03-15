using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsApp1.Models;

namespace WinFormsApp1.Databases
{
    internal class SuporteContext : DbContext
    {

        Settings setup = new Settings();

        private string _connectionString;
        //private string _connectionString = @"Data Source=192.168.18.100,1431;Initial Catalog=AS_CAD;User ID=sa;Password=1s860t77r@;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
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
    }
}
