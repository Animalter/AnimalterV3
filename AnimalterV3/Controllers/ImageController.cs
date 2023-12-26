using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.Context;
using AnimalterV3.Utilities.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        #region Fields
        private readonly IImageService _ımageService;
        #endregion

        #region ctor
        public ImageController(IImageService ımageService)
        {
            _ımageService = _ımageService;
        }
        #endregion

        #region methods

        [HttpGet("GetImageById")]
        public async Task<Image> GetImageById(int Id)
        {
            return _ımageService.GetById(Id);
        }
        //[HttpGet]
        //public async Task<List<Image>> GetAllImage()
        //{
        //    return _ımageService.Getall();
        //}
        [HttpPost]
        public async Task<IUtilityResult> AdImage(ImageDto ımageDto)
        {
            return _ımageService.Add(ımageDto);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateImage(ImageDto ımageDto)
        {
            return _ımageService.Update(ımageDto);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteImage(ImageDto ımageDto)
        {
            return _ımageService.Delete(ımageDto);
        }

        #endregion}



        //[HttpPost("upload")]
        //public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        //{
        //    if (file == null || file.Length == 0)
        //        return BadRequest("Invalid file");

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        await file.CopyToAsync(memoryStream);
        //        var imageData = memoryStream.ToArray();

        //        var image = new Image
        //        {
        //            FileName = file.FileName,
        //            Data = imageData
        //        };

        //        _context.Images.Add(image);
        //        await _context.SaveChangesAsync();

        //        return Ok("Image uploaded successfully");
        //    }
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetImage(int id)
        //{
        //    var image = await _context.Images.FindAsync(id);

        //    if (image == null)
        //        return NotFound();

        //    return File(image.Data, "image/jpeg");
        //}
    }
}
