using System.Security.Cryptography.Pkcs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class TrainerID : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            //builder.HasKey(c => c.TrainerID);

            builder.HasData(
               new Trainer
               {
                   Id = 1,
                   Name = "Mr Goh",
                   ContactInfo = "12345678",
                   YearsOfExperience = 12,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Trainer
               {
                   Id = 2,
                   Name = "Mr Tang",
                   ContactInfo = "87654321",
                   YearsOfExperience = 8,
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}