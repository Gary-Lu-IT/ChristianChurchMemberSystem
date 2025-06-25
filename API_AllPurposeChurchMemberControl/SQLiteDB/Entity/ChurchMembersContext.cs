using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_AllPurposeChurchMemberControl.SQLiteDB.Entity;

public partial class ChurchMembersContext : DbContext
{
    public ChurchMembersContext()
    {
    }

    public ChurchMembersContext(DbContextOptions<ChurchMembersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<announcements> announcements { get; set; }

    public virtual DbSet<attendance> attendance { get; set; }

    public virtual DbSet<event_attendance> event_attendance { get; set; }

    public virtual DbSet<events> events { get; set; }

    public virtual DbSet<families> families { get; set; }

    public virtual DbSet<login_logs> login_logs { get; set; }

    public virtual DbSet<members> members { get; set; }

    public virtual DbSet<offerings> offerings { get; set; }

    public virtual DbSet<users> users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=ChurchMembers.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<announcements>(entity =>
        {
            entity.Property(e => e.posted_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("DATETIME");
        });

        modelBuilder.Entity<attendance>(entity =>
        {
            entity.Property(e => e.event_date).HasColumnType("DATE");
            entity.Property(e => e.status).HasDefaultValue("Present");

            entity.HasOne(d => d.member).WithMany(p => p.attendance)
                .HasForeignKey(d => d.member_id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<event_attendance>(entity =>
        {
            entity.Property(e => e.attended)
                .HasDefaultValue(false)
                .HasColumnType("BOOLEAN");

            entity.HasOne(d => d._event).WithMany(p => p.event_attendance)
                .HasForeignKey(d => d.event_id)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.member).WithMany(p => p.event_attendance)
                .HasForeignKey(d => d.member_id)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<events>(entity =>
        {
            entity.Property(e => e.event_date).HasColumnType("DATE");
        });

        modelBuilder.Entity<login_logs>(entity =>
        {
            entity.Property(e => e.login_time)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("DATETIME");

            entity.HasOne(d => d.user).WithMany(p => p.login_logs).HasForeignKey(d => d.user_id);
        });

        modelBuilder.Entity<members>(entity =>
        {
            entity.Property(e => e.baptism_date).HasColumnType("DATE");
            entity.Property(e => e.baptized)
                .HasDefaultValue(false)
                .HasColumnType("BOOLEAN");
            entity.Property(e => e.birthdate).HasColumnType("DATE");
            entity.Property(e => e.stopusedate).HasColumnType("datetime");
            entity.Property(e => e.transferred)
                .HasDefaultValue(false)
                .HasColumnType("BOOLEAN");
        });

        modelBuilder.Entity<offerings>(entity =>
        {
            entity.Property(e => e.offer_date).HasColumnType("DATE");

            entity.HasOne(d => d.member).WithMany(p => p.offerings).HasForeignKey(d => d.member_id);
        });

        modelBuilder.Entity<users>(entity =>
        {
            entity.HasIndex(e => e.username, "IX_users_username").IsUnique();

            entity.HasOne(d => d.member).WithMany(p => p.users).HasForeignKey(d => d.member_id);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
