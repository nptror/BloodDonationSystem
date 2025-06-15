using System;
using System.Collections.Generic;
using BDS.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Data;

public partial class BloodDonationDbContext : DbContext
{
    public BloodDonationDbContext()
    {
    }

    public BloodDonationDbContext(DbContextOptions<BloodDonationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BloodCompatibility> BloodCompatibilities { get; set; }

    public virtual DbSet<BloodComponentType> BloodComponentTypes { get; set; }

    public virtual DbSet<BloodDonationRegister> BloodDonationRegisters { get; set; }

    public virtual DbSet<BloodInventory> BloodInventories { get; set; }

    public virtual DbSet<BloodRequest> BloodRequests { get; set; }

    public virtual DbSet<BloodType> BloodTypes { get; set; }

    public virtual DbSet<DonationForm> DonationForms { get; set; }

    public virtual DbSet<ReportLog> ReportLogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=EMBEYEUCUAANH\\SQLEXPRESS;Database=BloodDonationDB;User Id=sa;Password=12345;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BloodCompatibility>(entity =>
        {
            entity.HasKey(e => e.CompatibilityId).HasName("PK__BloodCom__637D0D52A65C4433");

            entity.HasOne(d => d.ComponentType).WithMany(p => p.BloodCompatibilities).HasConstraintName("FK__BloodComp__compo__5629CD9C");

            entity.HasOne(d => d.DonorBloodType).WithMany(p => p.BloodCompatibilityDonorBloodTypes).HasConstraintName("FK__BloodComp__donor__5441852A");

            entity.HasOne(d => d.RecipientBloodType).WithMany(p => p.BloodCompatibilityRecipientBloodTypes).HasConstraintName("FK__BloodComp__recip__5535A963");
        });

        modelBuilder.Entity<BloodComponentType>(entity =>
        {
            entity.HasKey(e => e.ComponentTypeId).HasName("PK__BloodCom__B4DB9EEE66348332");
        });

        modelBuilder.Entity<BloodDonationRegister>(entity =>
        {
            entity.HasKey(e => e.RegisterId).HasName("PK__BloodDon__0F673668095B364B");

            entity.Property(e => e.Status).HasDefaultValue("Pending");

            entity.HasOne(d => d.User).WithMany(p => p.BloodDonationRegisters).HasConstraintName("FK__BloodDona__userI__44FF419A");
        });

        modelBuilder.Entity<BloodInventory>(entity =>
        {
            entity.HasKey(e => e.BloodBagId).HasName("PK__BloodInv__7CA7D7B394479CE5");

            entity.HasOne(d => d.BloodType).WithMany(p => p.BloodInventories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BloodInve__blood__412EB0B6");

            entity.HasOne(d => d.ComponentType).WithMany(p => p.BloodInventories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BloodInve__compo__4222D4EF");
        });

        modelBuilder.Entity<BloodRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK__BloodReq__E3C5DE31BE9D2C31");

            entity.Property(e => e.Status).HasDefaultValue("Pending");

            entity.HasOne(d => d.BloodType).WithMany(p => p.BloodRequests).HasConstraintName("FK__BloodRequ__blood__4AB81AF0");

            entity.HasOne(d => d.Staff).WithMany(p => p.BloodRequestStaffs).HasConstraintName("FK__BloodRequ__staff__4E88ABD4");

            entity.HasOne(d => d.User).WithMany(p => p.BloodRequestUsers).HasConstraintName("FK__BloodRequ__userI__49C3F6B7");
        });

        modelBuilder.Entity<BloodType>(entity =>
        {
            entity.HasKey(e => e.BloodTypeId).HasName("PK__BloodTyp__C879D074273BEA28");
        });

        modelBuilder.Entity<DonationForm>(entity =>
        {
            entity.HasOne(d => d.Request).WithMany(p => p.DonationForms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DonationF__reque__59FA5E80");

            entity.HasOne(d => d.User).WithMany(p => p.DonationForms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DonationF__userI__59063A47");
        });

        modelBuilder.Entity<ReportLog>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__ReportLo__1C9B4E2D10446FC2");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ReportLogs).HasConstraintName("FK__ReportLog__creat__5165187F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__CB9A1CFF19A0DC65");

            entity.HasOne(d => d.BloodType).WithMany(p => p.Users).HasConstraintName("FK__User__bloodTypeI__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
