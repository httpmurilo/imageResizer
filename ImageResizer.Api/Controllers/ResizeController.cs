using System;
using System.Threading.Tasks;
using ImageResizer.Api.Util;
using Microsoft.AspNetCore.Mvc;

namespace ImageResizer.Api.Controllers
{

    [Route("api/image")]
    [ApiController]
    public class ResizeController : ControllerBase
    {
        private  PathValidator _path;
        public ResizeController(PathValidator path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetImage(string name)
        {
            _path.GetImageDirectory(name);

        }
    }
}
