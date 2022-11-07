using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace boilerplateasp.EntityFrameworkCore
{
    public static class boilerplateaspDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<boilerplateaspDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<boilerplateaspDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
