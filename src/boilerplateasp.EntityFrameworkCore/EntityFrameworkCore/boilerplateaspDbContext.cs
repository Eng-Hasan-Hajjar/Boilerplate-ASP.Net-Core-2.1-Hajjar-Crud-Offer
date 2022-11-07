using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boilerplateasp.Authorization.Roles;
using boilerplateasp.Authorization.Users;
using boilerplateasp.MultiTenancy;
using boilerplateasp.Offers;

namespace boilerplateasp.EntityFrameworkCore
{
    public class boilerplateaspDbContext : AbpZeroDbContext<Tenant, Role, User, boilerplateaspDbContext>
    {
        public DbSet<Offer> Offers { get; set; }    
        /* Define a DbSet for each entity of the application */
        
        public boilerplateaspDbContext(DbContextOptions<boilerplateaspDbContext> options)
            : base(options)
        {
        }
    }
}
