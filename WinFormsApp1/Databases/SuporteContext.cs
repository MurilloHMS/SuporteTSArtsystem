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
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AS_SuporteTS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conexoes> Conexoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder
                .UseSqlServer(_connectionString)
                .UseLazyLoadingProxies();
        }
    }
}
