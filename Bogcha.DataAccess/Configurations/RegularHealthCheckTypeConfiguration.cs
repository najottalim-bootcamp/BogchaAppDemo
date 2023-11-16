namespace Bogcha.DataAccess.Configurations;
public class RegularHealthCheckTypeConfiguration : IEntityTypeConfiguration<RegularHealthCheck>
{
    public void Configure(EntityTypeBuilder<RegularHealthCheck> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CheckupDate)
            .IsRequired();
        builder.Property(x=> x.Symptom)
            .HasMaxLength(100)
            .IsRequired(false);
        builder.Property(x=>x.ActionRequired)
            .HasMaxLength(100)
            .IsRequired(false);
            
    }
}
