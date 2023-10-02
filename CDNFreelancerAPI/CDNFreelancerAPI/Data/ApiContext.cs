using Microsoft.EntityFrameworkCore;
using CDNFreelancerAPI.Models;

namespace CDNFreelancerAPI.Data
{
    public class ApiContext: DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
