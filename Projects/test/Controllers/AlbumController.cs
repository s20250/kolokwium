using System;
using System.Threading.Tasks;
using kolokwium_s20250.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace kolokwium_s20250.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumDbService _ialbumDbService;
        public AlbumController(IAlbumDbService albumDbService)
        {
            _ialbumDbService = albumDbService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAlbums(int idAlbum)
        {
            try
            {
                if (idAlbum != null)
                    return Ok(await _ialbumDbService.GetAlbums(idAlbum));
                return Ok(await _ialbumDbService.GetAlbums());
            }
            catch (System.Exception)
            {
                return Conflict();
            }

        }

    }
}