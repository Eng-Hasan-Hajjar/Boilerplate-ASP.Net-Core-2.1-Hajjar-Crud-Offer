using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using boilerplateasp.Configuration;
using boilerplateasp.Web;

namespace boilerplateasp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class boilerplateaspDbContextFactory : IDesignTimeDbContextFactory<boilerplateaspDbContext>
    {
        public boilerplateaspDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<boilerplateaspDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            boilerplateaspDbContextConfigurer.Configure(builder, configuration.GetConnectionString(boilerplateaspConsts.ConnectionStringName));

            return new boilerplateaspDbContext(builder.Options);
        }
    }
}
