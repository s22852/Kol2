using Kol2_ko_s22852.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol2_ko_s22852.Configurations
{
    public class MusicianConfiguration : IEntityTypeConfiguration<Musician>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Musician> builder)
        {
            builder.ToTable("Musician");
            builder.HasKey(e => e.IdMusician);
            builder.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Nickname).HasMaxLength(20).IsRequired(false);
            builder.HasData(
                new Musician
                {
                    IdMusician = 1,
                    FirstName = "Siema",
                    LastName = "Test",
                    Nickname = "Guy"
                });
        }
    }
}