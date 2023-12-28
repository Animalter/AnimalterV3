using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;

namespace AnimalterV3.Busssines.Abstract
{
    public interface ICustomerService 
    {
        Customer GetById(int id);
        List<Customer> Getall();
        IUtilityResult Add(CustomerDto customer);
        IUtilityResult Update(CustomerDto customer);
        IUtilityResult Delete(int CustomerId);
    }
}
