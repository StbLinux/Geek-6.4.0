using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Geek.AbpGeek.EntityFrameworkCore
{
    public static class AbpGeekDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpGeekDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString,option=>option.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<AbpGeekDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, option => option.UseRowNumberForPaging());
        }
    }
}