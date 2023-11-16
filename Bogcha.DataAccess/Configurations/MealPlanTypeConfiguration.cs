namespace Bogcha.DataAccess.Configurations;

public class MealPlanTypeConfiguration : IEntityTypeConfiguration<MealPlan>
{
    public void Configure(EntityTypeBuilder<MealPlan> builder)
    {
        // Configure the primary key and other properties
        builder.HasKey(x => x.MealNo);
        builder.Property(x => x.DateName)
               .HasMaxLength(9)
               .IsRequired();
        builder.Property(x => x.MealNo)
               .HasMaxLength(4)
               .IsRequired();
        builder.Property(x => x.AM_Snack)
               .HasMaxLength(30)
               .IsRequired();
        builder.Property(x => x.Lunch)
               .HasMaxLength(50)
               .IsRequired();
        builder.Property(x => x.Fruit)
               .HasMaxLength(20)
               .IsRequired();
        builder.Property(x => x.PM_Snack)
               .HasMaxLength(50)
               .IsRequired();

        // Configure the inverse relationships
        builder.HasMany(x => x.MondayManagements)
               .WithOne(x => x.MondayMeal)
               .HasForeignKey(x => x.Monday)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.TuesdayManagements)
               .WithOne(x => x.TuesdayMeal)
               .HasForeignKey(x => x.Tuesday)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.WednesdayManagements)
               .WithOne(x => x.WednesdayMeal)
               .HasForeignKey(x => x.Wednesday)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.ThursdayManagements)
               .WithOne(x => x.ThursdayMeal)
               .HasForeignKey(x => x.Thursday)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(x => x.FridayManagements)
               .WithOne(x => x.FridayMeal)
               .HasForeignKey(x => x.FridayId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
