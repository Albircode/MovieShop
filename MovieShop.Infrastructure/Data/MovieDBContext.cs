using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieShop.Infrastructure.Data
{
   public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(ConfigureMovie);
            modelBuilder.Entity<Trailer>(configureTrailer);
            modelBuilder.Entity<Cast>(ConfigureCast);
            modelBuilder.Entity<MovieCast>(ConfigureMoviecast);
            modelBuilder.Entity<Crew>(configureCrew);
            modelBuilder.Entity<MovieCrew>(ConfigureMovieCrew);
            modelBuilder.Entity<Favorite>(ConfigureFavorite);
            modelBuilder.Entity<Purchase>(ConfigurePurchase);
            modelBuilder.Entity<Review>(configureReview);
            modelBuilder.Entity<User>(configureUser);
            modelBuilder.Entity<Role>(configureRole);
            modelBuilder.Entity<MovieGenre>(configureMovieGenre);

            


        }
        private void ConfigureCast(EntityTypeBuilder<Cast> builder)
        {
            builder.ToTable("Cast");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(128);
            builder.Property(t => t.Gender);
            builder.Property(t => t.TmdbUrl);
            builder.Property(t => t.ProfilePath).HasMaxLength(2084);

        }
        private void ConfigureMoviecast(EntityTypeBuilder<MovieCast> builder)
        {
            builder.ToTable("MovieCast");
            builder.HasKey(t =>new { t.MovieId, t.CastId });
            builder.Property(t => t.Character).HasMaxLength(450);
        }
        private void ConfigureFavorite(EntityTypeBuilder<Favorite> builder)
        {
            builder.ToTable("Favorite");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.MovieId);
            builder.Property(t => t.UserId);
        }
        private void ConfigurePurchase(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("Purchase");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.MovieId);
            builder.Property(t => t.UserId);
            builder.Property(t => t.PurchaseNumber);
            builder.Property(t => t.TotalNumber);
            builder.Property(t => t.PurchaseDateTime);

        }
        private void ConfigureMovieCrew(EntityTypeBuilder<MovieCrew> builder)
        {
            builder.ToTable("MovieCrew");
            builder.HasKey(t => new { t.MovieId, t.CrewId });
            builder.Property(t => t.Department).HasMaxLength(128);
            builder.Property(t => t.Job).HasMaxLength(128);

        }
        private void configureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(m => m.Id);
            builder.Property(t => t.Name).HasMaxLength(20);
        }
        private void configureCrew(EntityTypeBuilder<Crew> builder)
        {
            builder.ToTable("Crew");
            builder.HasKey(m => m.Id);
            builder.Property(t => t.Gender).HasMaxLength(4000);
            builder.Property(t => t.Name).HasMaxLength(2084);
            builder.Property(t => t.TmdbUrl).HasMaxLength(4000);
            builder.Property(t => t.ProfilePath).HasMaxLength(2084);

        }
        private void configureReview(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Review");
            builder.HasKey(m => new { m.MovieId, m.UserId });
            builder.Property(t => t.Rating);
            builder.Property(t => t.ReviewText).HasMaxLength(4000);
        }
        private void configureTrailer(EntityTypeBuilder<Trailer> builder)
        {
            builder.ToTable("Trailer");
            builder.HasKey(m => m.Id);
            builder.Property(t => t.TrailerUrl).HasMaxLength(2084);
            builder.Property(t => t.Name).HasMaxLength(2084);
        }
        private void configureMovieGenre(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.ToTable("MovieGenre");
            builder.HasKey(m =>new { m.GenreId, m.MovieId });
           
        }
        private void ConfigureMovie(EntityTypeBuilder<Movie> builder)
        {
            //place to convigur our movie entity
            builder.ToTable("Movie");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Title).IsRequired().HasMaxLength(256);
            builder.Property(m => m.Overview).HasMaxLength(4096);

            builder.Property(m => m.Tagline).HasMaxLength(512);
            builder.Property(m => m.ImdbUrl).HasMaxLength(2084);
            builder.Property(m => m.TmdbUrl).HasMaxLength(2084);
            builder.Property(m => m.PosterUrl).HasMaxLength(2084);
            builder.Property(m => m.BackdropUrl).HasMaxLength(2084);
            builder.Property(m => m.OriginalLanguage).HasMaxLength(64);
            builder.Property(m => m.Price).HasColumnType("decimal(5, 2)").HasDefaultValue(9.9m);
            builder.Property(m => m.CreatedDate).HasDefaultValueSql("getdate()");
        }
        private void configureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(t => t.FirstName).HasMaxLength(128);
            builder.Property(t => t.LastName).HasMaxLength(128);
            builder.Property(t => t.DateOfBirth).HasMaxLength(7);
            builder.Property(t => t.Email).HasMaxLength(256);
            builder.Property(t => t.HashedPassword).HasMaxLength(1024);
            builder.Property(t => t.Salt).HasMaxLength(1024);
            builder.Property(t => t.PhoneNumber).HasMaxLength(16);
            builder.Property(t => t.TwoFactorEnabled);
            builder.Property(t => t.LockOutEndDate).HasMaxLength(7);
            builder.Property(t => t.LastLoginDateTime).HasMaxLength(7);
            builder.Property(t => t.IsLocked);
            builder.Property(t => t.AccessFailedCount);

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<MovieCrew> MovieCrews{ get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }

        public DbSet<Review> Review { get; set; }

    }
}
