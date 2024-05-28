using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { ID=1,Title="INR",Description="Indian INR"},
                new Currency() { ID=2,Title="Dollar",Description="Dollar"},
                new Currency() { ID=3,Title="Euro",Description="Euro"},
                new Currency() { ID=4,Title="Dinar",Description="Dinar"}
                );

            modelBuilder.Entity<Language>().HasData(
               new Language() { ID = 1, Title = "Hindi", Description = "Hindi" },
               new Language() { ID = 2, Title = "Tamil", Description = "Tamil" },
               new Language() { ID = 3, Title = "Punjabi", Description = "punjabi" },
               new Language() { ID = 4, Title = "Urdu", Description = "Urdu" }
               );
        }



        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}
