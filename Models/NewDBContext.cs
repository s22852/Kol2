using Kol2.Configurations;
using Kol2.Models;
using Kol2.Models.DTOs;
using Kol2_ko_s22852.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Kol2_ko_s22852.Models
{
    public class NewDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public NewDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MusicianConfiguration());
            modelBuilder.ApplyConfiguration(new TrackConfiguration());
            modelBuilder.ApplyConfiguration(new MusicianTracksConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new MusicLabelConfiguration());
        }
    }
}