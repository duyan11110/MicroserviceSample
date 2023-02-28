using Microsoft.EntityFrameworkCore;
using Sample.Test1Service.UTIMaintenanceByCtParties;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Sample.Test1Service.EntityFrameworkCore;

public static class Test1ServiceDbContextModelCreatingExtensions
{
    public static void ConfigureTest1Service(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        #region Entities
        builder.Entity<UTIMaintenanceByCtParty>(entity =>
        {
            entity.ToTable(Test1ServiceDbProperties.DbTablePrefix + "UTIMaintenanceByCtParty", Test1ServiceDbProperties.DbSchema);
            entity.ConfigureByConvention();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.CancelApprovedDate).HasColumnType("datetime");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.TransType)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });
        #endregion

        #region Views
        builder.Entity<UTIMaintenanceByCtPartyGetListView>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("vTest1_UTIMaintenanceByCtParty_GetList", Test1ServiceDbProperties.DbSchema);
        });
        #endregion
    }
}
