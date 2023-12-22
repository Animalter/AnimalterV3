﻿using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Busssines.Service;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Abstract.DataAcces.Abstract;
using AnimalterV3.Entity.Abstract.Entites;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;

namespace AnimalterV3.Busssines.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IUtilityResult Add(CustomerDto customerDto)
        {
            Customer customer = new Customer();
            customer.CustomerPhoneNumber = customerDto.CustomerPhoneNumber; 
            customer.Customername = customerDto.Customername;   
            customer.CustomerMail=customerDto.CustomerMail; 
            customer.CustomerPassword = customerDto.CustomerPassword;   
            _customerDal.Add(customer);
            return new SuccessReasult();
        }
        public IUtilityResult Delete(CustomerDto customerDto)
        {
            var customer = new Customer();
            customer.CustomerMail = customerDto.CustomerMail;
            customer.CustomerPassword = customerDto.CustomerPassword;
            customer.CustomerPhoneNumber = customerDto.CustomerPhoneNumber;
            customer.Customername = customerDto.Customername;
            _customerDal.Delete(customer);
            return new SuccessReasult();
        }
        public List<Customer> Getall()
        {
            return _customerDal.GetAll().ToList();
        }
        public IUtilityResult Update(CustomerDto customerDto)
        {
            var customer = new Customer();
            customer.CustomerMail = customerDto.CustomerMail;
            customer.CustomerPassword = customerDto.CustomerPassword;
            customer.CustomerPhoneNumber=customerDto.CustomerPhoneNumber;
            customer.Customername = customerDto.Customername;

            _customerDal.Update(customer);
            return new SuccessReasult();
        }
       
    }
}