using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IAdoptionStatusService
    {
        AdoptionStatus GetById(int id);
        List<AdoptionStatus> Getall();
        IUtilityResult Add(AdoptionStatusDto adoptionStatus);
        IUtilityResult Update(AdoptionStatusDto adoptionStatus);
        IUtilityResult Delete(int  AdoptionStatusId);
    }
}
