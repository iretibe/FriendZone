using FriendZone.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendZone.Entities
{
    public class FriendZoneDbContext : DbContext
    {
        public FriendZoneDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            base.OnModelCreating(optionsBuilder);
        }
    }
}
