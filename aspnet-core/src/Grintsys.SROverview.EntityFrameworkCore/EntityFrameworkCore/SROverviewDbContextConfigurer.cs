using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Grintsys.SROverview.EntityFrameworkCore
{
    public static class SROverviewDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SROverviewDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SROverviewDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
