using Bills.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bills
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var conString = configuration.GetConnectionString("DefaultConnection");

            var basePath = Directory.GetCurrentDirectory();

            var DbPath = Path.Combine(basePath, "bills.db");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite($"Data Source={DbPath}");

            var dbContext = new AppDbContext(optionsBuilder.Options);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(dbContext));
        }
    }
}