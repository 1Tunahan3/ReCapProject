﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Buisness.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}