using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
  public  class CarImageManager:ICarImageService
  {
      private ICarImageDal _carImageDal;

      public CarImageManager(ICarImageDal carImageDal)
      {
          _carImageDal = carImageDal;
      }

      public IDataResult<List<CarImage>> GetAll()
      {
          
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> Get()
        {
            return new SuccessDataResult<CarImage>();
        }

        public IResult Add(CarImage carImage)
        {
            if (ChechIImageLimitExceded(carImage).Succes)
            {
                _carImageDal.Add(carImage);
                return new SuccesResult();
            }

          return new ErrorResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
           return new SuccesResult();
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccesResult();
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int id)
        {
            var result2 = _carImageDal.GetAll(p => p.CarId == id).Any();

            if (result2)
            {
                return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == id));
            }
            else
            {
                return new SuccessDataResult<List<CarImage>>();
            }

          
        }


        private IResult ChechIImageLimitExceded(CarImage carImage)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carImage.CarId).Count();
            if (result >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }
            return new SuccesResult();
        }
    }
}
