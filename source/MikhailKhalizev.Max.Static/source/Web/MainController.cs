using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using MikhailKhalizev.Max.Program;

namespace MikhailKhalizev.Max
{
    [Route("api")]
    [ApiController]
    public class MainController : ControllerBase
    {
        public static string GetImageUrl() => $"api/image?t={DateTime.UtcNow.Ticks}";

        public RawProgramMain RawProgramMain { get; }

        public MainController(RawProgramMain rawProgramMain)
        {
            RawProgramMain = rawProgramMain;
        }

        [HttpGet("image")]
        public ActionResult Get()
        {
            var png = RawProgramMain.DosInterrupt.PngBytes;
            if (png == null)
                return NoContent();
            return File(new MemoryStream(png, false), "image/png");
        }
    }
}