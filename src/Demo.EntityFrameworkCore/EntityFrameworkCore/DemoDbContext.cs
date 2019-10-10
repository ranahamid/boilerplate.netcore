using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Demo.Authorization.Roles;
using Demo.Authorization.Users;
using Demo.MultiTenancy;
using Demo.Tasks;

namespace Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<AppTasks> Tasks { get; set; }

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }
    }
}
