using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OzoneFitness.Domain;

namespace OzoneFitness.Configurations.Entities
{
    public class CustomerID : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //builder.HasKey(c => c.CustomerID); 

            builder.HasData(
               new Customer
               {
                   CustomerId = 1,
                   Name = "Jonas",
                   Email = "Jonas@gmail.com",
                   MembershipStatus = "Member",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               },
               new Customer
               {
                   CustomerId = 2,
                   Name = "Sherman",
                   Email = "Sherman@gmail.com",
                   MembershipStatus = "Nil",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now,
                   CreatedBy = "System",
                   UpdatedBy = "System"
               }
            );
        }
    }
}