using FriendZone.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendZone.Entities
{
    public class FriendZoneDbContext : DbContext
    {
        public FriendZoneDbContext(DbContextOptions<FriendZoneDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Friend> Friends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
