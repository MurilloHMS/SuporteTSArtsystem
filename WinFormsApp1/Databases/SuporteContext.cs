using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinFormsApp1.Models;

namespace WinFormsApp1.Databases
{
    internal class SuporteContext : DbContext
    {
        //private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AS_CAD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string _connectionString = @"Data Source=DESKTOP-TC9U938\CONTROLEFP;Initial Catalog=AS_CAD;User ID=sa;Password=1525;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<ASENTENT> ASENTENT { get; set; }
        public DbSet<Conexoes> Conexoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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
