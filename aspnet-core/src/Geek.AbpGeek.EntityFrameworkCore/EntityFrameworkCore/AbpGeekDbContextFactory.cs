using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Geek.AbpGeek.Configuration;
using Geek.AbpGeek.Web;

namespace Geek.AbpGeek.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpGeekDbContextFactory : IDesignTimeDbContextFactory<AbpGeekDbContext>
    {
        public AbpGeekDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpGeekDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            AbpGeekDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpGeekConsts.ConnectionStringName));

            return new AbpGeekDbContext(builder.Options);
        }
    }
}