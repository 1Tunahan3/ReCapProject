using System;
using System.Collections.Generic;
using System.Text;

using Business.Constants;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Buisness.Concrete
{
   public class CarManager:ICarService
   {
       private ICarDal _carDal;

       public CarManager(ICarDal carDal)
       {
           _carDal = carDal;
       }


       public IDataResult<List<Car>> GetAll()
       {
           if (DateTime.Now.Hour==23)
           {
               return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
           }

           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ProductsListed) ;
       }

       public IDataResult<List<Car>> GetCarsByBrandId(int id)
       {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
       }

       public IDataResult<List<Car>> GetCarsByColorId(int id)
       {
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
       }

       public IDataResult<Car> GetById(int id)
       {
          return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id==id));
       }


        [ValidationAspect(typeof(CarValidator))]
       public IResult Add(Car car)
       {
           _carDal.Add(car);
            return  new SuccesResult(Messages.CarAdded);
       }



       public IResult Delete(Car car)
       {
           _carDal.Delete(car);
           return new SuccesResult();
        }

       public IResult Update(Car car)
       {
          _carDal.Update(car);
          return new SuccesResult();
        }

       public IDataResult<List<CarDetatilDto>> GetCarDetail()
       {
           return new SuccessDataResult<List<CarDetatilDto>>(_carDal.GetCarDetail());
       }
   }
}
