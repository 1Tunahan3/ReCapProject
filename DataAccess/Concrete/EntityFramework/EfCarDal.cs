using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarDal:EfEntityRepositoryBase<Car,CarRecapContext>,ICarDal
    {
        public List<CarDetatilDto> GetCarDetail()
        {
            using (CarRecapContext context=new CarRecapContext())
            {
                var result = from car in context.Cars
                             join c in context.Brands on car.BrandId equals c.BrandId 
                             join t in context.Colors on car.ColorId equals t.id
                    select new CarDetatilDto
                    {
                       BrandName =c.BrandName ,ColorName = t.Name, DailyPrice =car.DailyPrice,ModelYear = car.ModelYear,Description = car.Description
                    };
                return result.ToList();
            }
        }
    }
}
