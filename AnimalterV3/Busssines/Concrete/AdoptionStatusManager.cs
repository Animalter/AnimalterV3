using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Entity.Concrete.EntityFramework;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;

namespace AnimalterV3.Busssines.Concrete
{
    public class AdoptionStatusManager : IAdoptionStatusService
    {
        private IAdoptionStatusDal _adoptionStatusDal;
        public AdoptionStatusManager(IAdoptionStatusDal adoptionStatusDal)
        {
            _adoptionStatusDal = adoptionStatusDal;

        }
       
        public IUtilityResult Add(AdoptionStatusDto adoptionStatusDto)
        {
            AdoptionStatus adoptionStatus = new AdoptionStatus();
            
            adoptionStatus.AdoptionDate = adoptionStatusDto.AdoptionDate;
            adoptionStatus.AnimalId = adoptionStatusDto.AnimalId;
            adoptionStatus.UserId = adoptionStatusDto.UserId;
            _adoptionStatusDal.Add(adoptionStatus);
            return new SuccessReasult();

        }
        public List<AdoptionStatus> Getall()
        {
            return _adoptionStatusDal.GetAll();
        }
        public IUtilityResult Update(AdoptionStatusDto adoptionStatusDto)
        {
            AdoptionStatus adoptionStatus = new AdoptionStatus();
            adoptionStatus.AnimalId = adoptionStatusDto.AnimalId;
            adoptionStatus.AdoptionDate = adoptionStatusDto.AdoptionDate;
            adoptionStatus.UserId = adoptionStatusDto.UserId;
            _adoptionStatusDal.Update(adoptionStatus);
            return new SuccessReasult();
        }
        public IUtilityResult Delete(int  adoptionStatusId)
        {
            AdoptionStatus adoptionStatus = new AdoptionStatus();
            AdoptionStatus adoptionStatus1 = _adoptionStatusDal.GetAll(x => x.AdoptionId ==adoptionStatusId).FirstOrDefault();
            if (adoptionStatus1 == null)
            {
                return new ErrorResult("User Bulunamadı");
            }

            _adoptionStatusDal.Delete(adoptionStatus);
            return new SuccessReasult();
        }

        public AdoptionStatus GetById(int id)
        {
            return _adoptionStatusDal.GetAll(x => x.AdoptionId == id) != null ? _adoptionStatusDal.GetAll(x => x.AdoptionId == id).FirstOrDefault() : new AdoptionStatus();
        }
    }
}
