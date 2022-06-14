using System.Threading.Tasks;
using Kol2.Models.DTOs;
using Kol2_ko_s22852.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kol2_ko_s22852.Controllers
{
    [Route("api/[controller]")]
    public class NewController : ControllerBase
    {
        private readonly INewService _service;
        public NewController(INewService service)
        {
            _service = service;            
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _service.GetAlbumById(id);
            if (album is null) return BadRequest("There is no album with this id");
            var tracks = await _service.GetTracksByAlbumId(id);
            return Ok(
                new GetAlbum{
                IdAlbum = album.IdAlbum,
                AlbumName = album.AlbumName,
                PublishDate = album.PublishDate,
                IdMusicLabel = album.IdMusicLabel,
                Tracks = tracks
                }
            );
        }
    }
}