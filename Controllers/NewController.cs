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
    }
}