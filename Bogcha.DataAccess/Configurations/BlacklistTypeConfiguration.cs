namespace Bogcha.DataAccess.Configurations;
internal class BlacklistTypeConfiguration : IEntityTypeConfiguration<BlackList>
{
    public void Configure(EntityTypeBuilder<BlackList> builder)
    {
        builder.HasKey(x => x.ChId);
    }
}
