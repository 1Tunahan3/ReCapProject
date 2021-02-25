using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Concrete
{
  public  class RentalManager:IRentalService
  {
      private IRentalDal _rentalDal;

      public RentalManager(IRentalDal rentalDal)
      {
          _rentalDal = rentalDal;
      }

      public IDataResult<List<Rental>> GetAll()
      {
          return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
      }

      public IDataResult<Rental> GetById(int id)
      {
          return new SuccessDataResult<Rental>(_rentalDal.Get(p=>p.Id==id));
      }

      [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
      {
          
          _rentalDal.Add(rental);
          return new SuccesResult();
      }

      public IResult Delete(Rental rental)
      {
          _rentalDal.Delete(rental);
          return new SuccesResult();
      }

      public IResult Update(Rental rental)
      {
          _rentalDal.Update(rental);
         return new SuccesResult();
      }
  }
}
