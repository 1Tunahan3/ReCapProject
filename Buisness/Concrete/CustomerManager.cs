using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Concrete
{
   public class CustomerManager:ICustomerService
   {
       private ICustomerDal _customerDal;

       public CustomerManager(ICustomerDal customerDal)
       {
           _customerDal = customerDal;
       }

       public IDataResult<List<Customer>> GetAll()
       {
           return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
       }

       public IDataResult<Customer> GetById(int id)
       {
          return new SuccessDataResult<Customer>(_customerDal.Get(t=>t.Id==id));
       }

       public IResult Add(Customer customer)
       {
           _customerDal.Add(customer);
          return new SuccesResult();
       }

       public IResult Delete(Customer customer)
       {
           _customerDal.Delete(customer);
           return new SuccesResult();
       }

       public IResult Update(Customer customer)
       {
           _customerDal.Update(customer);
          return new SuccesResult();
       }
   }
}
