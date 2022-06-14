using System.Threading.Tasks;
using Kol2_ko_s22852.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kol2.Controllers
{
    [Route("api/[controller]")]
    public class MusicianController : ControllerBase
    {
         private readonly INewService _service;
        public MusicianController(INewService service)
        {
            _service = service;            
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var mus = await _service.GetMusicianById(id);
            if(mus is null) return BadRequest("Nie ma takiego muzyka");
            await _service.DeleteMusician(mus);
            await _service.SaveDatabase();
            return NoContent();
        }
    }
}