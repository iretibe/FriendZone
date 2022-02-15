using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FriendZone.Entities
{
    public class FriendZoneDbContextFactory : IDesignTimeDbContextFactory<FriendZoneDbContext>
    {
        public FriendZoneDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<FriendZoneDbContext>();

            options.UseSqlServer("Server=PSL-DBSERVER-VM3\\SQL2012;Database=FriendZoneDb;user id=sa;password=SymBoL$1948;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");

            return new FriendZoneDbContext(options.Options);
        }
    }
}
