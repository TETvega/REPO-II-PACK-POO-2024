using Microsoft.EntityFrameworkCore;

namespace RepoPOO.Database
{
    public class RepoPOOContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public RepoPOOContext(DbContextOptions options) : base(options)
        {
            
        }

        //public DbSet<CategoryProductEntity> CategoryProducts { get; set; }
        //public DbSet<ClientTypeEntity> TypesOfClient { get; set; }
        //public DbSet<DetailEntity> Details { get; set; }
        //public DbSet<EventEntity> Events { get; set; }
        //public DbSet<NoteEntity> Notes { get; set; }
        //public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<ReservationEntity> Reservations { get; set; }

        //public DbSet<UserEntity> Users { get; set; }
    }
}
