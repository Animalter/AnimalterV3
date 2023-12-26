using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;

namespace AnimalterV3.Busssines.Concrete
{
    public class PetOwnerManager : IPetOwnerService
    {
        private IPetOwnerDal _petOwner;
        public PetOwnerManager(IPetOwnerDal petOwnerDal)
        {
            _petOwner = petOwnerDal;
        }
      
        public IUtilityResult Add(PetOwnerDto petOwnerDto)
        {
           PetOwner petOwner=new PetOwner();
            petOwner.PetownerId = petOwnerDto.PetownerId;
            petOwner.AdoptionStatusId=petOwnerDto.AdoptionStatusId;
            petOwner.AdoptionDate=petOwnerDto.AdoptionDate;
            petOwner.AnimalId=petOwnerDto.AnimalId;
            petOwner.CustomerId=petOwnerDto.CustomerId;

            return new SuccessReasult();
        }

        public IUtilityResult Delete(PetOwnerDto petOwnerDto)
        {
            PetOwner petOwner = new PetOwner();
            petOwner.PetownerId = petOwnerDto.PetownerId;
            petOwner.AdoptionStatusId = petOwnerDto.AdoptionStatusId;
            petOwner.AdoptionDate = petOwnerDto.AdoptionDate;
            petOwner.AnimalId = petOwnerDto.AnimalId;
            petOwner.CustomerId = petOwnerDto.CustomerId;

            return new SuccessReasult();
        }

        public List<PetOwner> Getall()
        {
            return _petOwner.GetAll();
        }

        public PetOwner GetById(int id)
        {
            return _petOwner.GetAll(x => x.PetownerId == id) != null ? _petOwner.GetAll(x => x.AnimalId == id).FirstOrDefault() : new PetOwner(); ;
        }

        public IUtilityResult Update(PetOwnerDto petOwnerDto)
        {
            PetOwner petOwner = new PetOwner();
            petOwner.PetownerId = petOwnerDto.PetownerId;
            petOwner.AdoptionStatusId = petOwnerDto.AdoptionStatusId;
            petOwner.AdoptionDate = petOwnerDto.AdoptionDate;
            petOwner.AnimalId = petOwnerDto.AnimalId;
            petOwner.CustomerId = petOwnerDto.CustomerId;

            return new SuccessReasult();
        }
    }
}
