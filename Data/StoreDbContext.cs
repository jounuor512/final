using Microsoft.EntityFrameworkCore;
using SchoolS4.Model;


namespace SchoolS4.Data
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext>options):base(options) { }


        public DbSet<Movie>movies { get; set; }
        public DbSet<Hall> halls { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Ticket).WithOne()
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }

    }
}
