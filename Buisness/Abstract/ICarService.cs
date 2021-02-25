using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitize.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);


       IDataResult<List<CarDetatilDto>> GetCarDetail();
    }
}
