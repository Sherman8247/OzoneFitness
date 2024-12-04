using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OzoneFitness.Domain;

public class CustomerID : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.CustomerID); 

        builder.HasData(
           new Customer
           {
               CustomerID = 1, 
               Name = "Jonas",
               DateCreated = DateTime.Now,
               DateUpdated = DateTime.Now,
               CreatedBy = "System",
               UpdatedBy = "System"
           },
           new Customer
           {
               CustomerID = 2, 
               Name = "Sherman",
               DateCreated = DateTime.Now,
               DateUpdated = DateTime.Now,
               CreatedBy = "System",
               UpdatedBy = "System"
           }
        );
    }
}
