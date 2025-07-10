using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CometSocial.EntityFrameworkCore
{
    public static class CometSocialDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CometSocialDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CometSocialDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
