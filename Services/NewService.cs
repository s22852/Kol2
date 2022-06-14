using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kol2.Models;
using Kol2.Models.DTOs;
using Kol2_ko_s22852.Models;
using Microsoft.EntityFrameworkCore;

namespace Kol2_ko_s22852.Services
{
    public class NewService : INewService
    {
        private readonly NewDBContext _context;

        public NewService(NewDBContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteMusician(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteMusician(Musician mus)
        {
            throw new System.NotImplementedException();
        }

        public async Task<GetAlbum> GetAlbumById(int id)
        {
            var album =  await _context.Albums.FirstOrDefaultAsync(e => e.IdAlbum == id);
            if (album is null) return null;
            return new GetAlbum{
                IdAlbum = album.IdAlbum,
                AlbumName = album.AlbumName,
                PublishDate = album.PublishDate,
                IdMusicLabel = album.IdMusicLabel,
            };
        }

        public async Task<Musician> GetMusicianById(int id)
        {
            var mus =  await _context.Musicians.FirstOrDefaultAsync(e => e.IdMusician == id);
            if (mus is null) return null;
            return mus;
        }

        public async Task<List<GetTrack>> GetTracksByAlbumId(int id)
        {
            return await _context.Tracks.OrderBy(e => e.Duration).Where(e => e.IdMusicAlbum == id).Select(e => new GetTrack{
                IdTrack = e.IdTrack,
                TrackName = e.TrackName,
                Duration = e.Duration,
                IdMusicAlbum = e.IdMusicAlbum
            }).ToListAsync();
        }

        public async Task SaveDatabase()
        {
            await _context.SaveChangesAsync();
        }
    }
}