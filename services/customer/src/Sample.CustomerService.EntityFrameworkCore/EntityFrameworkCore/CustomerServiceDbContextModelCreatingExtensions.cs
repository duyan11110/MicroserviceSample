using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Sample.CustomerService.EntityFrameworkCore;

public static class CustomerServiceDbContextModelCreatingExtensions
{
    public static void ConfigureCustomerService(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Customers.Customer>(entity =>
        {
            entity.ToTable(CustomerServiceDbProperties.DbTablePrefix + "Customer", CustomerServiceDbProperties.DbSchema);
            entity.ConfigureByConvention();

            entity.HasKey(e => e.CustomerID)
                    .HasName("pk_tCIM_Customer_ID");

            entity.HasIndex(e => e.CompanyID, "IX_tCIM_Customer_CompanyID")
                .HasFillFactor(80);

            entity.HasIndex(e => e.CustomerAbbr, "ix_tCIM_Customer_CustomerAbrr")
                .HasFillFactor(80);

            entity.Property(e => e.CustomerID).ValueGeneratedNever();

            entity.Property(e => e.Address)
                .HasMaxLength(70)
                .IsUnicode(false);

            entity.Property(e => e.CustomerAbbr)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LicenseNumber)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PassportNo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });
    }
}
