using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OzoneFitness.Configurations.Entities;
using OzoneFitness.Domain;

namespace OzoneFitness.Data
{
    public class OzoneFitnessContext(DbContextOptions<OzoneFitnessContext> options)
        : IdentityDbContext<IdentityUser>(options)
    {
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Feedback> Feedback { get; set; } = default!;
        public DbSet<Gym> Gym { get; set; } = default!;
        public DbSet<Schedule> Schedule { get; set; } = default!;
        public DbSet<Trainer> Trainer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder) // Fix casing issue
        {
            base.OnModelCreating(builder);

            // Apply configurations
            builder.ApplyConfiguration(new CustomerID());
            builder.ApplyConfiguration(new GymID());
            builder.ApplyConfiguration(new TrainerID());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());

            // Explicitly set primary key for Customer
            builder.Entity<Customer>()
                .HasKey(c => c.CustomerId);

            // Ensure Image is stored correctly
            builder.Entity<Trainer>()
                .Property(t => t.Image)
                .HasColumnType("varbinary(max)");

            builder.Entity<Customer>()
                .Property(c => c.Image)
                .HasColumnType("varbinary(max)");
        }
    }
}
