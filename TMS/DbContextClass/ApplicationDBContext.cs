
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TMS.Models;

namespace TMS.DbContextClass
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUsers>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Students> students { get; set; }
    }
}
