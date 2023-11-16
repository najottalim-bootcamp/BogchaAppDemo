namespace Bogcha.DataAccess.Configurations;
internal class AccidentRecordTypeConfiguration : IEntityTypeConfiguration<AccidentRecords>
{
    public void Configure(EntityTypeBuilder<AccidentRecords> builder)
    {
        builder.HasKey(x => x.AccNo);

        builder.HasOne(x=>x.Studnet)
            .WithMany(x=>x.Accident_Records)
            .HasForeignKey(x=>x.ChId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.AccidentDate)
            .IsRequired();
        builder.Property(x=>x.TypeOfAccident)
            .HasMaxLength(20)
            .IsRequired();
        builder.Property(x => x.Location)
            .HasMaxLength(20)
            .IsRequired();
        builder.Property(x => x.FirstAid)
            .HasMaxLength(12)
            .IsRequired();
            
    }
}
