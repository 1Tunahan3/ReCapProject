using System;
using System.Collections.Generic;
using System.Text;
using Buisness.Abstract;
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

      public IResult Add(Rental rental)
      {
          if (rental.ReturnDate==null)
          {
              return new ErrorResult();
          }

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
