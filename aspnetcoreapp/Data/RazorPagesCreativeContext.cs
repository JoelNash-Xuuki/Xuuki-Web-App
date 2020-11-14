using Microsoft.EntityFrameworkCore;

namespace RazorPagesCreative.Data
{
    public class RazorPagesCreativeContext : DbContext
    {
        public RazorPagesCreativeContext (
            DbContextOptions<RazorPagesCreativeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCreative.Models.Creative> Creative { get; set; }
    }
}
