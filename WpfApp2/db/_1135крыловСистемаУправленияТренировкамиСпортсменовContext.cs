using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WpfApp2.db;

public partial class _1135крыловСистемаУправленияТренировкамиСпортсменовContext : DbContext
{
    public _1135крыловСистемаУправленияТренировкамиСпортсменовContext()
    {
    }

    public _1135крыловСистемаУправленияТренировкамиСпортсменовContext(DbContextOptions<_1135крыловСистемаУправленияТренировкамиСпортсменовContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Athlete> Athletes { get; set; }

    public virtual DbSet<AthleteCategory> AthleteCategories { get; set; }

    public virtual DbSet<AthleteTrainingLevel> AthleteTrainingLevels { get; set; }

    public virtual DbSet<Participation> Participations { get; set; }

    public virtual DbSet<Progre> Progres { get; set; }

    public virtual DbSet<Training> Training { get; set; }

    public virtual DbSet<TypeOfTraining> TypeOfTrainings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("userid=student;password=student;database=\"1135КрыловСистема управления тренировками спортсменов\";server=192.168.200.13", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.39-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Athlete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Athlete");

            entity.HasIndex(e => e.IdAthleteSTrainingLevel, "FK_Athlete_id_Athlete'sTrainingLevel");

            entity.HasIndex(e => e.IdAthleteCategory, "FK_Athlete_id_AthleteCategory");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.IdAthleteCategory)
                .HasColumnType("int(11)")
                .HasColumnName("id_AthleteCategory");
            entity.Property(e => e.IdAthleteSTrainingLevel)
                .HasColumnType("int(11)")
                .HasColumnName("id_Athlete'sTrainingLevel");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");

            entity.HasOne(d => d.IdAthleteCategoryNavigation).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.IdAthleteCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Athlete_id_AthleteCategory");

            entity.HasOne(d => d.IdAthleteSTrainingLevelNavigation).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.IdAthleteSTrainingLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Athlete_id_Athlete'sTrainingLevel");
        });

        modelBuilder.Entity<AthleteCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("AthleteCategory");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<AthleteTrainingLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("AthleteTrainingLevel");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<Participation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Participation");

            entity.HasIndex(e => e.IdAthlete, "FK_Participation_id_Athlete");

            entity.HasIndex(e => e.IdTraining, "FK_Participation_id_Training");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdAthlete)
                .HasColumnType("int(11)")
                .HasColumnName("id_Athlete");
            entity.Property(e => e.IdTraining)
                .HasColumnType("int(11)")
                .HasColumnName("id_Training");

            entity.HasOne(d => d.IdAthleteNavigation).WithMany(p => p.Participations)
                .HasForeignKey(d => d.IdAthlete)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Participation_id_Athlete");

            entity.HasOne(d => d.IdTrainingNavigation).WithMany(p => p.Participations)
                .HasForeignKey(d => d.IdTraining)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Participation_id_Training");
        });

        modelBuilder.Entity<Progre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdParticipation, "FK_Progres_id_Participation");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Комментарий не оставлен'")
                .HasColumnName("comment");
            entity.Property(e => e.Grade)
                .HasColumnType("int(11)")
                .HasColumnName("grade");
            entity.Property(e => e.IdParticipation)
                .HasColumnType("int(11)")
                .HasColumnName("id_Participation");

            entity.HasOne(d => d.IdParticipationNavigation).WithMany(p => p.Progres)
                .HasForeignKey(d => d.IdParticipation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Progres_id_Participation");
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasIndex(e => e.IdTypeOfTraining, "FK_Training_id_TypeOfTraining");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateOfTraining)
                .HasColumnType("datetime")
                .HasColumnName("date_of_training");
            entity.Property(e => e.IdTypeOfTraining)
                .HasColumnType("int(11)")
                .HasColumnName("id_TypeOfTraining");
            entity.Property(e => e.Time)
                .HasColumnType("int(11)")
                .HasColumnName("time");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.IdTypeOfTrainingNavigation).WithMany(p => p.Training)
                .HasForeignKey(d => d.IdTypeOfTraining)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Training_id_TypeOfTraining");
        });

        modelBuilder.Entity<TypeOfTraining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("TypeOfTraining");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
