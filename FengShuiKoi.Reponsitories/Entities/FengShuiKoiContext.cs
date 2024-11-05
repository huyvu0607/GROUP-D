using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class FengShuiKoiContext : DbContext
{
    public FengShuiKoiContext()
    {
    }

    public FengShuiKoiContext(DbContextOptions<FengShuiKoiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<KoiAccount> KoiAccounts { get; set; }

    public virtual DbSet<UserMember> UserMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-I957D0S\\SQLSVV;Initial Catalog=FengShuiKoi;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KoiAccount>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK__KoiAccou__91CBC3983F3FF491");

            entity.ToTable("KoiAccount");

            entity.HasIndex(e => e.EmailAddress, "UQ__KoiAccou__49A147401D31B497").IsUnique();

            entity.Property(e => e.AccId)
                .ValueGeneratedNever()
                .HasColumnName("AccID");
            entity.Property(e => e.Description).HasMaxLength(140);
            entity.Property(e => e.EmailAddress).HasMaxLength(90);
            entity.Property(e => e.Password).HasMaxLength(90);
        });

        modelBuilder.Entity<UserMember>(entity =>
        {
            entity.HasKey(e => e.FullName).HasName("PK__UserMemb__89C60F1034ED058E");

            entity.ToTable("UserMember");

            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Accid).HasColumnName("ACCID");
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.Destiny)
                .HasMaxLength(30)
                .HasColumnName("destiny");

            entity.HasOne(d => d.Acc).WithMany(p => p.UserMembers)
                .HasForeignKey(d => d.Accid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__UserMembe__ACCID__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
