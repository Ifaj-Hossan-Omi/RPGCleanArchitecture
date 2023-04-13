using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RPG.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }


        public DbSet<User> Users => Set<User>();
        public DbSet<Character> Characters => Set<Character>();
    }
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        // private IDesignTimeDbContextFactory<DataContext> _designTimeDbContextFactoryImplementation;
        public DataContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                // .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionBuilder = new DbContextOptionsBuilder<DataContext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new DataContext(optionBuilder.Options);
            // return _designTimeDbContextFactoryImplementation.CreateDbContext(args);
        }
    }

}
