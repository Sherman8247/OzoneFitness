using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class GymID : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.HasKey(c => c.GymId);

            builder.HasData(
               new Gym
               {
                   GymId = 1,
                   Address = "Pasir ris Mall",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Gym
               {
                   GymId = 2,
                   Address = "Tampines Mall",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}
