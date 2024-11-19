using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bills.Models;
using Microsoft.EntityFrameworkCore;

namespace Bills.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Item> ItensFatura { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fatura>()
                .HasOne(f => f.Cliente)
                .WithMany(c => c.Faturas)
                .HasForeignKey(f => f.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Item>()
                .HasOne(i => i.Fatura)
                .WithMany(f => f.Itens)
                .HasForeignKey(i => i.FaturaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
