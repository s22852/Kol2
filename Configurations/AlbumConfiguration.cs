using Kol2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kol2.Configurations
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");
            builder.HasKey(e => e.IdAlbum);
            builder.Property(e => e.AlbumName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.PublishDate).IsRequired();
            builder.Property(e => e.IdMusicLabel).IsRequired();
            builder.HasOne(e => e.MusicLabel).WithMany(e => e.Albums).HasForeignKey(e => e.IdMusicLabel);

            builder.HasData(
                new Album
                {
                    IdAlbum = 1,
                    AlbumName = "AlbumTest",
                    PublishDate = System.DateTime.Now,
                    IdMusicLabel = 1
                }
            );
        }
    }
}