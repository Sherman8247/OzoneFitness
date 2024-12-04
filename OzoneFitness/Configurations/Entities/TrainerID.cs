using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class TrainerID : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(c => c.TrainerID);

            builder.HasData(
               new Trainer
               {
                   TrainerID = 1,
                   Name = "Mr Goh",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Trainer
               {
                   TrainerID = 2,
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
