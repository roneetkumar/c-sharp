using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Final_Roneet.Model
{
    public partial class SMTI_Teacher_Course_FinalContext : DbContext
    {
        public SMTI_Teacher_Course_FinalContext()
        {
        }

        public SMTI_Teacher_Course_FinalContext(DbContextOptions<SMTI_Teacher_Course_FinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CourseAssignment> CourseAssignment { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QH6HUUD;Database=SMTI_Teacher_Course_Final;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseAssignment>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.TeacherId });

                entity.Property(e => e.CourseId).HasMaxLength(50);

                entity.Property(e => e.AssignmentDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseAssignment)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseAssignment_Courses");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.CourseAssignment)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseAssignment_Teachers");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.Property(e => e.CourseId).HasMaxLength(50);

                entity.Property(e => e.CourseName).HasMaxLength(100);
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.JobTitle).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
