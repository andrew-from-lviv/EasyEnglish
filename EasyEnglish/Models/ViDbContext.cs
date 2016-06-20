using System.Data.Entity;

namespace EasyEnglish.Models {
    public class ViDbContext : DbContext {
        public ViDbContext()
            : base("ViConnection") {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
