using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class TrainerID : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(c => c.TrainerId);

            builder.HasData(
               new Trainer
               {
                   TrainerId = 1,
                   Name = "Mr Goh",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Trainer
               {
                   TrainerId = 2,
                   Name = "Mr Tang",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}
