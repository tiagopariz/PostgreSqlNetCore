using System;
using Microsoft.EntityFrameworkCore;
using PostgreSqlNetCore.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PostgreSqlNetCore.Infra.Data.Context
{
    public class PostgreSqlContext : DbContext
    {
        private readonly IConfigurationRoot _configurationFile;
        private readonly string _connectionString;

        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) :
            base(options)
        {
            _configurationFile = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json")
                                    .Build();

            _connectionString = _configurationFile
                                    .GetConnectionString("PostgreSqlNetCoreConnection");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }

        public PostgreSqlContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
    
            var builder = new DbContextOptionsBuilder<CodingBlastDbContext>();
    
            var connectionString = configuration.GetConnectionString("DefaultConnection");
    
            builder.UseSqlServer(connectionString);
    
            return new CodingBlastDbContext(builder.Options);
        }
    }
}