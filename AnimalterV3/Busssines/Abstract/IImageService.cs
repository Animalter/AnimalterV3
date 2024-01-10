using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;

using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IImageService
    {
        Image GetById(int id);

        List<Image> Getall();
        IUtilityResult Add(ImageDto ımage);
        IUtilityResult Update(ImageDto ımage);
        IUtilityResult Delete(ImageDto ımage);
        bool UploadImage(IFormFile formFile);
    }
}
