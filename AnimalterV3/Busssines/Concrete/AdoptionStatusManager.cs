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
            adoptionStatus.AdoptionDate = adoptionStatusDto.AdoptionDate;
            _adoptionStatusDal.Update(adoptionStatus);
            return new SuccessReasult();
        }
        public IUtilityResult Delete(AdoptionStatusDto adoptionStatusDto)
        {
            AdoptionStatus adoptionStatus = new AdoptionStatus();
            adoptionStatus.AdoptionDate = adoptionStatusDto.AdoptionDate;
            _adoptionStatusDal.Delete(adoptionStatus);
            return new SuccessReasult();
        }

        public AdoptionStatus GetById(int id)
        {
            return _adoptionStatusDal.GetAll(x => x.AdoptionId == id) != null ? _adoptionStatusDal.GetAll(x => x.AdoptionId == id).FirstOrDefault() : new AdoptionStatus();
        }
    }
}
