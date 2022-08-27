using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Acme.SimpleTaskApp.Configuration;
using Acme.SimpleTaskApp.Web;

namespace Acme.SimpleTaskApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SimpleTaskAppDbContextFactory : IDesignTimeDbContextFactory<SimpleTaskAppDbContext>
    {
        public SimpleTaskAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SimpleTaskAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SimpleTaskAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SimpleTaskAppConsts.ConnectionStringName));

            return new SimpleTaskAppDbContext(builder.Options);
        }
    }
}
