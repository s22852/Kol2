using Kol2_ko_s22852.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kol2_ko_s22852.Configurations
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.ToTable("Track");
            builder.HasKey(e => e.IdTrack);
            builder.Property(e => e.TrackName).HasMaxLength(20).IsRequired();
            builder.Property(e => e.Duration).IsRequired();
            builder.Property(e => e.IdMusicAlbum).IsRequired(false);

            builder.HasOne(e => e.Album).WithMany(e => e.Tracks).HasForeignKey(e => e.IdMusicAlbum);

            builder.HasData(
                new Track
                {
                    IdTrack = 1,
                    TrackName = "Track1",
                    Duration = 20,
                    IdMusicAlbum = 1
                },
                new Track
                {
                    IdTrack = 2,
                    TrackName = "Track2",
                    Duration = 25,
                    IdMusicAlbum = 1
                },
                new Track
                {
                    IdTrack = 3,
                    TrackName = "Track3",
                    Duration = 3
                }
            );

        }
    }
}