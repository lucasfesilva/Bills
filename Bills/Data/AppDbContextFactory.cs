using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Bills.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var projectRoot = Directory.GetParent(currentDir).FullName;

            string targetDir = Path.Combine(projectRoot, "bin", "debug", "net6.0-windows");
            Directory.SetCurrentDirectory(targetDir);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var conString = configuration.GetConnectionString("DefaultConnection");

            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "bills.db");

            if (!Directory.Exists(Directory.GetCurrentDirectory()))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory());
            }

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite(conString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
