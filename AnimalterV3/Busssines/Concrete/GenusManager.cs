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
    public class GenusManager: IGenusService
    {
        private IGenusDal _genusDal;

        public GenusManager(IGenusDal genusDal )
        {
            _genusDal = genusDal;
            
        }
        public IUtilityResult Add(GenusDto genusDto)
        {
            Genus genus = new Genus();
            genus.Genuss=genusDto.Genuss;
            _genusDal.Add(genus);
            return new SuccessReasult();

        }
        public List<Genus> Getall()
        {
            return _genusDal.GetAll();
        }
        public IUtilityResult Update(GenusDto genusDto)
        {
            var genus = new Genus();
            genus.GenusId=genusDto.GenusId;
            genus.Genuss = genusDto.Genuss;
             _genusDal.Update(genus);
            return new SuccessReasult();
        }
        //public IUtilityResult Delete(GenusDto genusDto)
        //{
        //    var genus = new Genus();
        //    genus.GenusId= genusDto.GenusId;
        //    genus.Genuss= genusDto.Genuss;  
        //    _genusDal.Delete(genus);
        //    return new SuccessReasult();
        //}
        public IUtilityResult Delete(int GenusId)
        {
            Genus genus = _genusDal.GetAll(x => x.GenusId == GenusId).FirstOrDefault();
            if (genus == null)
            {
                return new ErrorResult("cins Bulunamadı");
            }
            _genusDal.Delete(genus);
            return new SuccessReasult();
        }

        public Genus GetById(int id)
        {
            return _genusDal.GetAll(x => x.GenusId == id) != null ? _genusDal.GetAll(x => x.GenusId == id).FirstOrDefault() : new Genus();
        }
    }
}
