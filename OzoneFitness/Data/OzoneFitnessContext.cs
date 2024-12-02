using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OzoneFitness.Domain;

namespace OzoneFitness.Data
{
    public class OzoneFitnessContext : DbContext
    {
        public OzoneFitnessContext (DbContextOptions<OzoneFitnessContext> options)
            : base(options)
        {
        }

        public DbSet<OzoneFitness.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Feedback> Feedback { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Gym> Gym { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Schedule> Schedule { get; set; } = default!;
        public DbSet<OzoneFitness.Domain.Trainer> Trainer { get; set; } = default!;
    }
}
