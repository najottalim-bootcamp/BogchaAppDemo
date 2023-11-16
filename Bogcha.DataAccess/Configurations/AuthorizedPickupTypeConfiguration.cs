namespace Bogcha.DataAccess.Configurations;
internal class AuthorizedPickupTypeConfiguration : IEntityTypeConfiguration<AuthorizedPickUp>
{
    public void Configure(EntityTypeBuilder<AuthorizedPickUp> builder)
    {
        builder.HasKey(x => x.ChId);
        builder.HasOne(x => x.Studnet)
            .WithMany(x => x.AuthorizedPickUps)
            .HasForeignKey(x => x.ChId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.AuthFName)
            .HasMaxLength(25)
            .IsRequired();
        builder.Property(x=>x.AuthLName)
            .HasMaxLength(25)
            .IsRequired();
        builder.Property(x=>x.gender)
            .HasMaxLength(1)
            .IsRequired();
        builder.Property(x=>x.Passport)
            .HasMaxLength(11)
            .IsRequired();
        builder.Property(x=>x.strAddress)
            .HasMaxLength(30)
            .IsRequired();
        builder.Property(x=>x.city)
            .HasMaxLength(25)
            .IsRequired();
        builder.Property(x => x.region)
            .HasMaxLength(20)
            .IsRequired();
        builder.Property(x=>x.zipCode)
            .HasMaxLength(5)
            .IsRequired();
        builder.Property(x=>x.phoneNo)
            .HasMaxLength(15)
            .IsRequired();
    }
}
