using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OzoneFitness.Configurations.Entities;

namespace OzoneFitness.Data
{
    public class OzoneFitnessContext(DbContextOptions<OzoneFitnessContext> options) : IdentityDbContext<IdentityUser>(options)
    {
        public DbSet<OzoneFitness.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Gym> Gym { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Schedule> Schedule { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Trainer> Trainer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new CustomerID());
            Builder.ApplyConfiguration(new GymID());
            Builder.ApplyConfiguration(new TrainerID());
            Builder.ApplyConfiguration(new RoleSeed());
            Builder.ApplyConfiguration(new UserRoleSeed());
            Builder.ApplyConfiguration(new UserSeed());
        }
    }
}