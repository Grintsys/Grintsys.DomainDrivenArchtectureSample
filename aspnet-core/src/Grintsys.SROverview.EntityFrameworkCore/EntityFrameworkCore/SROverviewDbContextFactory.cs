using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Grintsys.SROverview.Configuration;
using Grintsys.SROverview.Web;

namespace Grintsys.SROverview.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SROverviewDbContextFactory : IDesignTimeDbContextFactory<SROverviewDbContext>
    {
        public SROverviewDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SROverviewDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SROverviewDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SROverviewConsts.ConnectionStringName));

            return new SROverviewDbContext(builder.Options);
        }
    }
}
