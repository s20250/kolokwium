using System;
using System.Threading.Tasks;
using Test.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace Test.Controllers
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

        public async Task<IActionResult> GetAlbums(int IdAlbum)
        {
            try
            {
                if (IdAlbum > 0)
                    return Ok(await _ialbumDbService.GetAlbums(IdAlbum));
                return Ok(await _ialbumDbService.GetAlbums());
            }
            catch (System.Exception)
            {
                return Conflict();
            }

        }

    }
}