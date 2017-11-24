using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Projet_Juju.Models
{
    public partial class JujuContext : DbContext
    {
        public virtual DbSet<Bet> Bet { get; set; }
        public virtual DbSet<BetType> BetType { get; set; }
        public virtual DbSet<Bookmaker> Bookmaker { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Paid> Paid { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<SignUpPrice> SignUpPrice { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public JujuContext(DbContextOptions<JujuContext> options) : base(options) { }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bet>(entity =>
            {
                entity.Property(e => e.Bet1).HasColumnName("Bet");

                entity.Property(e => e.BetDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IdBetType).HasColumnName("Id_BetType");

                entity.Property(e => e.IdBookmaker).HasColumnName("Id_Bookmaker");

                entity.Property(e => e.IdMatch).HasColumnName("Id_Match");

                entity.Property(e => e.IdTeam).HasColumnName("Id_Team");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.HasOne(d => d.IdBetTypeNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdBetType)
                    .HasConstraintName("FK_Bet_Id_BetType");

                entity.HasOne(d => d.IdBookmakerNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdBookmaker)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bet_Id_Bookmaker");

                entity.HasOne(d => d.IdMatchNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdMatch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bet_Id_Match");

                entity.HasOne(d => d.IdTeamNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bet_Id_Team");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Bet)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bet_Id_User");
            });

            modelBuilder.Entity<BetType>(entity =>
            {
                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bookmaker>(entity =>
            {
                entity.Property(e => e.Img)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.IdSeason).HasColumnName("Id_Season");

                entity.Property(e => e.IdTeam).HasColumnName("Id_Team");

                entity.Property(e => e.IdTeam1).HasColumnName("Id_Team_1");

                entity.Property(e => e.IdTeam2).HasColumnName("Id_Team_2");

                entity.Property(e => e.League)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MatchDate).HasColumnType("datetime");

                entity.Property(e => e.ScoreTeam1Prognosis).HasColumnName("ScoreTeam1_prognosis");

                entity.Property(e => e.ScoreTeam2Prognosis).HasColumnName("ScoreTeam2_prognosis");

                entity.HasOne(d => d.IdSeasonNavigation)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.IdSeason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Id_Season");

                entity.HasOne(d => d.IdTeamNavigation)
                    .WithMany(p => p.MatchIdTeamNavigation)
                    .HasForeignKey(d => d.IdTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Id_Team");

                entity.HasOne(d => d.IdTeam1Navigation)
                    .WithMany(p => p.MatchIdTeam1Navigation)
                    .HasForeignKey(d => d.IdTeam1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Id_Team_1");

                entity.HasOne(d => d.IdTeam2Navigation)
                    .WithMany(p => p.MatchIdTeam2Navigation)
                    .HasForeignKey(d => d.IdTeam2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Id_Team_2");
            });

            modelBuilder.Entity<Paid>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdPayment, e.IdSignUpPrice })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("paid");

                entity.Property(e => e.IdPayment).HasColumnName("Id_Payment");

                entity.Property(e => e.IdSignUpPrice).HasColumnName("Id_SignUpPrice");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Paid)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_paid_Id");

                entity.HasOne(d => d.IdPaymentNavigation)
                    .WithMany(p => p.Paid)
                    .HasForeignKey(d => d.IdPayment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_paid_Id_Payment");

                entity.HasOne(d => d.IdSignUpPriceNavigation)
                    .WithMany(p => p.Paid)
                    .HasForeignKey(d => d.IdSignUpPrice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_paid_Id_SignUpPrice");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignUpPrice>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Logo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Trigram)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Users__A9D10534B570A645")
                    .IsUnique();

                entity.HasIndex(e => e.Nickname)
                    .HasName("UQ__Users__CC6CD17E502E474C")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
