using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitize.Results;
using Entities.Concrete;

namespace Business.Abstract
{
  public  interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get();
        IResult Add(CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage);

        IDataResult<List<CarImage>> GetAllByCarId(int id);



    }
}
