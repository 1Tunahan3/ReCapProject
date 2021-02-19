using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Concrete
{
   public class BrandManager:IBrandService
   {
       private IBrandDal _brandDal;

       public BrandManager(IBrandDal brandDal)
       {
           _brandDal = brandDal;
       }

        public IResult Add(Brand brand)
        {
           _brandDal.Add(brand);
           return new SuccesResult();
        }

        public IResult Delete(Brand brand)
        {
           _brandDal.Delete(brand);
           return new SuccesResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
           return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.BrandId==id));
        }

        public IResult Update(Brand brand)
        {
           _brandDal.Update(brand);
           return new SuccesResult();
        }
    }
}
