using AmanahTeknologTask.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace AmanahTeknologTask.Domains
{
    public class DataContext : DbContext
    { 
        public DataContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<CompanyClient> CompanyClients { get; set; }
        public DbSet<IndividualClient> IndividualClients { get; set; }
        public DbSet<BankInformation> BankInformation { get; set; }
        public DbSet<CardInformation> CardInformation { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
