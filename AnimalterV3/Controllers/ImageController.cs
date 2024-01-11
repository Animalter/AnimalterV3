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
        private readonly IWebHostEnvironment _hostingEnvironment;
        #endregion

        #region ctor
        public ImageController(IImageService ımageService, IWebHostEnvironment hostingEnvironment)
        {
            _ımageService = ımageService;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region methods

        [HttpGet("GetImageById")]
        public async Task<Image> GetImageById(int Id)
        {
            return _ımageService.GetById(Id);
        }
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

        [HttpPost("upload")]
        public async Task<string> UploadImage(IFormFile formFile)
        {
            string defaultPath = System.IO.Directory.GetCurrentDirectory();

            using (var ms = new MemoryStream())
            {
                if (formFile == null || formFile.Length == 0)
                {

                    return null;
                }

                var fileName = System.IO.Path.GetFileName(formFile.FileName);
                var fileNameWithOutExtension = System.IO.Path.GetFileNameWithoutExtension(formFile.FileName);
                var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                var fileExtension = System.IO.Path.GetExtension(fileName);
                var newFileName = String.Concat(myUniqueFileName, fileExtension);

                var Upload = System.IO.Path.Combine(defaultPath, @"Images\", newFileName);

                using (var fileStream = new FileStream(Upload, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }

                return newFileName;
            }
        }


        //[HttpPost("upload")]
        //public async Task<string> UploadImage(IFormFile formFile)
        //{
        //    string defaultPath = System.IO.Directory.GetCurrentDirectory();
        //    if (formFile == null || formFile.Length == 0)
        //    {
        //        return "Invalid file";
        //    }
        //    using (var ms = new MemoryStream())
        //    {
        //        var fileName = System.IO.Path.GetFileName(formFile.FileName);
        //        var fileNameWithOutExtension = System.IO.Path.GetFileNameWithoutExtension(formFile.FileName);
        //        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
        //        var fileExtension = System.IO.Path.GetExtension(fileName);
        //        var newFileName = String.Concat(myUniqueFileName, fileExtension);



        //        if (formFile != null)
        //        {
        //            var Upload = System.IO.Path.Combine(defaultPath, @"Images\", newFileName);
        //            formFile.CopyTo(new FileStream(Upload, FileMode.Create));
        //        }
        //        return newFileName;
        //    }
        //}



        [HttpGet("imageName")]
        public byte[] GetImage(string imageName)
        {
            string defaultPath = System.IO.Directory.GetCurrentDirectory();
            var imagePath = Path.Combine(defaultPath, @"Images\", imageName);

            if (System.IO.File.Exists(imagePath))
            {
                var imageBytes = System.IO.File.ReadAllBytes(imagePath);
                byte[] imageBytes1 = System.IO.File.ReadAllBytes(imagePath);
                return imageBytes1; // veya uygun olan MIME türünü belirtin
            }

            return null;
        }
        #endregion

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
