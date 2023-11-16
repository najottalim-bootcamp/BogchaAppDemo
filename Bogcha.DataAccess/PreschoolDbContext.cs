using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bogcha.DataAccess;
public class PreschoolDbContext : DbContext
{
    public PreschoolDbContext(DbContextOptions<PreschoolDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
    public virtual DbSet<AccidentRecords> AccidentRecords { get; set; }
    public virtual DbSet<ActivityManagement> ActivityManagements { get; set; }
    public virtual DbSet<AssessmentRecKG> AssessmentRecKGs { get; set;}
    public virtual DbSet<AssessmentRecNursery> AssessmentRecNurseries { get; set; }
    public virtual DbSet<AssessmentRecPreK> AssessmentRecPreKs { get; set; }
    public virtual DbSet<Attendance> Attendances { get; set; }
    public virtual DbSet<AuthorizedPickUp> AuthorizedPickUps { get; set; }
    public virtual DbSet<BlackList> BlackLists { get; set; }
    public virtual DbSet<ClassInfo> ClassInfos { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<ImmunizationRecord> ImmunizationRecords { get; set; }
    public virtual DbSet<MenuManagement> MenuManagements { get; set; }
    public virtual DbSet<MealPlan> MealPlans { get; set; }
    public virtual DbSet<Parents> Parents { get; set; }
    public virtual DbSet<RegularHealthCheck> RegularHealthChecks { get; set; }
    public virtual DbSet<Revenue> Revenues { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Withdrawal> Withdrawals { get; set; }
}
