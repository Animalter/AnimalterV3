using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;



namespace AnimalterV3.Busssines.Concrete
{
    public class ImageManager : IImageService
    {

        private IImageDal _ımageDal;
        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;

        }
        public IUtilityResult Add(ImageDto ımageDal)
        {
            Image ımage = new Image();
            ımage.Id = ımageDal.Id;
            ımage.FileName = ımageDal.FileName;
            ımage.Data = ımageDal.Data;

            return new SuccessReasult();

        }
        public List<Image> Getall()
        {
            return _ımageDal.GetAll();
        }
        public IUtilityResult Update(ImageDto ımageDal)
        {
            var ımage = new Image();
            ımage.Id = ımageDal.Id;
            ımage.FileName = ımageDal.FileName;
            ımage.Data = ımageDal.Data;


            return new SuccessReasult();
        }
        public IUtilityResult Delete(ImageDto ımageDal)
        {
            var ımage = new Image();
            ımage.Id = ımageDal.Id;
            ımage.FileName = ımageDal.FileName;
            ımage.Data = ımageDal.Data;
            return new SuccessReasult();
        }
        public Image GetById(int id)
        {
            return _ımageDal.GetAll(x => x.Id == id) != null ? _ımageDal.GetAll(x => x.Id == id).FirstOrDefault() : new Image();
        }

        public bool UploadImage(IFormFile formFile)
        {


            return true;
        }
    }
}
