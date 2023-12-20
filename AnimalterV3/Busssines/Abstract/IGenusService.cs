using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IGenusService 
    {
            List<Genus> Getall();
            IUtilityResult Add(GenusDto genus);
            IUtilityResult Update(GenusDto genus);
            IUtilityResult Delete(GenusDto genus);
  
    }
}
