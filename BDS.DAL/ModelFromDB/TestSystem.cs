using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDS.DAL.ModelFromDB;

public partial class TestSystem : DbContext
{
    public TestSystem()
    {
    }

    public TestSystem(DbContextOptions<TestSystem> options)
        : base(options)
    {
    }

    public virtual DbSet<DonationRegistration> DonationRegistrations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-JBC3UOF\\MSSQLSERVER01;Database=TestSystem;User Id=sa;Password=12345;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DonationRegistration>(entity =>
        {
            entity.HasKey(e => e.DonationId).HasName("PK__Donation__296B91DC3976B465");

            entity.Property(e => e.Status).HasDefaultValue("Pending");

            entity.HasOne(d => d.User).WithMany(p => p.DonationRegistrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DonationRegistration_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__B9BE370FBBCAD92F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
