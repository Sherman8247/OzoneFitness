using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class GymID : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            //builder.HasKey(c => c.GymID);

            builder.HasData(
               new Gym
               {
                   Id = 1,
                   Address = "Pasir ris Mall",
                   OperatingHours = "12",
                   Capacity = 150,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Gym
               {
                   Id = 2,
                   Address = "Tampines Mall",
                   OperatingHours = "10",
                   Capacity = 200,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}
