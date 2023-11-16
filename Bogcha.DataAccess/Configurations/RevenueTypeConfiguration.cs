namespace Bogcha.DataAccess.Configurations;
public class RevenueTypeConfiguration : IEntityTypeConfiguration<Revenue>
{
    public void Configure(EntityTypeBuilder<Revenue> builder)
    {
        builder.HasKey(x => x.ChId);
        builder.HasOne(x => x.Studnet)
            .WithMany(x => x.Revenues)
            .HasForeignKey(x => x.ChId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.RegistrationFee)
            .IsRequired(false);
        builder.Property(x => x.Term1)
            .IsRequired(false);
        builder.Property(x => x.Term2)
            .IsRequired(false);
        builder.Property(x => x.Term3)
            .IsRequired(false);
        builder.Property(x => x.InvoiceNo)
            .HasMaxLength(20)
            .IsRequired(false);
        builder.Property(x => x.RecieptNo)
            .HasMaxLength(6)
            .IsRequired(false);
    }
}
