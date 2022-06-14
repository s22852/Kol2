using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kol2.Models;
using Kol2.Models.DTOs;
using Kol2_ko_s22852.Models;

namespace Kol2_ko_s22852.Services
{
    public interface INewService
    {
         public Task SaveDatabase();
         public Task<GetAlbum> GetAlbumById(int id);
         public Task<List<GetTrack>> GetTracksByAlbumId(int id);
         public Task<Musician> GetMusicianById(int id);
         public Task<Boolean> DeleteMusician(Musician mus);
    }
}