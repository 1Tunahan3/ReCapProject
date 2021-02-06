using System;
using Buisness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager=new CarManager(new EfCarDal());
           Car car = new Car
           {
               BrandId = 2,ColorId = 2,ModelYear = "2019",DailyPrice = 56000,Description = "SUV57"
           };
           carManager.Add(car);
        }
    }
}
