using Kol2_ko_s22852.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kol2_ko_s22852.Configurations
{
    public class MusicianTracksConfiguration : IEntityTypeConfiguration<Musician_Tracks>
    {
        public void Configure(EntityTypeBuilder<Musician_Tracks> builder)
        {
            builder.ToTable("Musician_Track");
            builder.HasKey(e => new { e.IdMusician, e.IdTrack});

            builder.HasOne(e => e.Musician).WithMany(e => e.Musician_Tracks).HasForeignKey(e => e.IdMusician);
            builder.HasOne(e => e.Track).WithMany(e => e.Musician_Tracks).HasForeignKey(e => e.IdTrack);

            builder.HasData(
                new Musician_Tracks
                {
                    IdTrack = 1,
                    IdMusician = 1
                },
                new Musician_Tracks
                {
                    IdTrack = 2,
                    IdMusician = 1
                },
                new Musician_Tracks
                {
                    IdTrack = 3,
                    IdMusician = 1
                });
        }
    }
}