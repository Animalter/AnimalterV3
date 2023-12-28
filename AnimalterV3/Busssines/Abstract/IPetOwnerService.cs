using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface IPetOwnerService
    {
        PetOwner GetById(int id);
        List<PetOwner> Getall();
        IUtilityResult Add(PetOwnerDto petOwnerDto);
        IUtilityResult Update(PetOwnerDto petOwnerDto);
        IUtilityResult Delete(int  PetOwnerId);
    }
}
