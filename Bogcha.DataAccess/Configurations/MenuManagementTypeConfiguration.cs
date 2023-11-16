namespace Bogcha.DataAccess.Configurations;
public class MenuManagementTypeConfiguration : IEntityTypeConfiguration<MenuManagement>
{
    public void Configure(EntityTypeBuilder<MenuManagement> builder)
    {
        builder.HasKey(x => x.ChId);
        builder.HasOne(x => x.Studnet)
            .WithMany(x => x.MenuManagements)
            .HasForeignKey(x => x.ChId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.MondayMeal)
            .WithMany(x => x.MondayManagements)
            .HasForeignKey(x => x.Monday)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.TuesdayMeal)
            .WithMany(x => x.TuesdayManagements)
            .HasForeignKey(x => x.Tuesday)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.WednesdayMeal)
            .WithMany(x => x.WednesdayManagements)
            .HasForeignKey(x => x.Wednesday)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(x => x.ThursdayMeal)
            .WithMany(x => x.ThursdayManagements)
            .HasForeignKey(x => x.Thursday)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.FridayMeal)
            .WithMany(x => x.FridayManagements) 
            .HasForeignKey(x => x.FridayId) 
            .OnDelete(DeleteBehavior.NoAction);    


    }
}
