using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImageMagick;
using imageresize.Converter;
using imageresize.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace imageresize.Controllers
{

    
    public partial class ImageResizeController : Controller
    {

        [HttpGet("api/images/resize")]
        public async Task<IActionResult> ResizeImage(
      [FromQuery]ResizeRequestModel requestModel,
      [FromServices] IHostingEnvironment env

       )

       {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var filePath = Path.Combine(env.ContentRootPath, "Images", requestModel.Name);
            var fileExists = System.IO.File.Exists(filePath);
            if (fileExists == false)
            { 
                return NotFound();
            }

            var options = ConversionOptionsFactory.FromResizeRequest(requestModel);
            //dispose corretamente
            using (var memory = new MemoryStream())
            using (var image = new MagickImage(filePath))
            {
                //forcar redimensiomaneto 100x100
                image.Resize(options.Width,options.Height);
                image.Strip();
                image.Quality = options.Quality;
                image.Format = options.TargetFormat;
                image.Write(memory);
                var file = memory.ToArray();
                return File(file,options.TargetMineType);

            }
        }
    }
}
