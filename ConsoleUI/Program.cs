using System;
using Buisness.Concrete;
using Business.Concrete;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager=new CarManager(new EfCarDal());
            //Car car = new Car
            //{
            //    BrandId = 2,ColorId = 2,ModelYear = "2019",DailyPrice = 56000,Description = "SUV57"
            //};
            //carManager.Add(car);
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            //ColorManager colorManager=new ColorManager(new EfColorDal());
            //Color color1 = new Color { Name = "Gri",id = 25};
            // colorManager.Delete(color1);
            // foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //CarManager carManager=new CarManager(new EfCarDal());
            //int num = 1;
            //foreach (var item in carManager.GetCarDetail().Data)
            //{
            //    Console.WriteLine(item.BrandName + " "+item.ColorName +" "+ item.DailyPrice+ " "+ item.ModelYear+ " "+ item.Description);
            //}

            //var deger = carManager.GetById(num).Data;
            // Console.WriteLine(deger.Description);
            // Console.WriteLine(deger.DailyPrice);
            //Console.WriteLine(deger.ModelYear);


          UserManager userManager=new UserManager(new EfUserDal());
          User user = new User
          {
              Id = 10,FirstName = "Tunahan",LastName = "Kaya",Email = "tunahankaya1@hotmail.com",Password = "Tuna13"
          };
          userManager.Add(user);
          foreach (var item in userManager.GetAll().Data)
          {
              Console.WriteLine(item.FirstName);
          }

          Console.WriteLine("-----------------------------------------");

          CustomerManager customerManager=new CustomerManager(new EfCustomerDal());
          Customer customer = new Customer
          {
              Id = 1, UserId = 10, CompanyName = "TunaYazılım"
          };
          customerManager.Add(customer);

          foreach (var item in customerManager.GetAll().Data)
          {
              Console.WriteLine(item.CompanyName);
          }

          Console.WriteLine("-----------------------------------------");

            RentalManager rentalManager=new RentalManager(new EfRentalDal());
            Rental rental = new Rental
            {
                Id = 1,CarId = 2,CustomerId = 10,RentDate =DateTime.Now,ReturnDate = DateTime.Now
            };
            rentalManager.Add(rental);

            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.RentDate);
            }


        }
    }
}
