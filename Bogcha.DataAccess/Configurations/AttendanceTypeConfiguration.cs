global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bogcha.DataAccess.Configurations;
internal class AttendanceTypeConfiguration : IEntityTypeConfiguration<Attendance>
{
    public void Configure(EntityTypeBuilder<Attendance> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Studnet)
            .WithMany(x => x.Attendances)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

        builder.Property(x => x.SignIn_Time)
            .IsRequired();
        builder.Property(x => x.SignOut_Time)
            .IsRequired();


    }
}
