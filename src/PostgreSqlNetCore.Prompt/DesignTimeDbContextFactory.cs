using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PostgreSqlNetCore.Infra.Data.Context;

namespace PostgreSqlNetCore.Prompt
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PostgreSqlContext>
    {
        public PostgreSqlContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<PostgreSqlContext>();
            var connectionString = configuration.GetConnectionString("PostgreSqlNetCoreConnection");
            builder.UseNpgsql(connectionString);
            return new PostgreSqlContext(builder.Options);
        }
    }
}