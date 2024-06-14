using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão dependde da sua máquina.
                optionsBuilder.UseSqlServer("Data Source=CONQUISTAR\\BANCOEXPRESS;Initial Catalog=ExoApi;User ID=SA;Password=livre;Encrypt=False");

            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}