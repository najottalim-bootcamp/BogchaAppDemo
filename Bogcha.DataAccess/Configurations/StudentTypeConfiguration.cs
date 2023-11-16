namespace Bogcha.DataAccess.Configurations;
internal class StudentTypeConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(x => x.CHId);
    }
}
