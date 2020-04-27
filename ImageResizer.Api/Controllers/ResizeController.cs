using System;
using System.Threading.Tasks;
using ImageResizer.Services.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ImageResizer.Api.Controllers
{
    public class ResizeController : ControllerBase
    {
        private readonly DefaultPath path;
        public ResizeController(DefaultPath path)
        {
            path =path ?? throw new ArgumentNullException(nameof(path));
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetImage(string name)
        {
            var fileExists = System.IO.File.Exists(path.filePath);
            if(fileExists == false)
            {
                return NotFound();
            }
            var file = await System.IO.File.ReadAllBytesAsync(path.filePath);
            return File(file, "image/jpeg");

        }
    }
}
