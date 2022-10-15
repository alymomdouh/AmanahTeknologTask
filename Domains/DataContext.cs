using AmanahTeknologTask.Domains.Models;
using Microsoft.EntityFrameworkCore;

namespace AmanahTeknologTask.Domains
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
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
            modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product {Id = 1, Name = "Product1",Price=10},
                new Product {Id = 2, Name = "Product2",Price=20},
                new Product {Id = 3, Name = "Product3",Price=30},
                new Product {Id = 4, Name = "Product4",Price=40},
                new Product {Id = 5, Name = "Product5",Price=50},
                new Product {Id = 6, Name = "Product6",Price=60},
            });
            modelBuilder.Entity<CompanyClient>().HasData(new CompanyClient { Id = 1, Name = "CompanyClient1", Email = "CompanyClient1@gmail.com" });
            modelBuilder.Entity<IndividualClient>().HasData(new IndividualClient { Id = 1, Name = "IndividualClient1", Email = "IndividualClient1@gmail.com" });
            modelBuilder.Entity<Tax>().HasData(new Tax { Id = 1, Name = "tax1", Value = 30 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
