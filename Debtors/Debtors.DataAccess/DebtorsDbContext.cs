using Debtors.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Debtors.DataAccess;

public class DebtorsDbContext : DbContext
{
    public DbSet<DebtEntity> Students { get; set; }
    public DbSet<DebtEntity> Debts { get; set; }
    public DbSet<SubjectEntity> Subjects { get; set; }
    public DbSet<TeacherEntity> Teachers { get; set; }
    public DbSet<AdminEntity> Admins { get; set; }

    public FitnessClubDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<UserEntity>().HasOne(x => x.Club)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.ClubId);

        modelBuilder.Entity<ClubEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<ClubEntity>().HasIndex(x => x.ExternalId).IsUnique();

        modelBuilder.Entity<TrainerEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<TrainerEntity>().HasIndex(x => x.ExternalId).IsUnique();
    }
}