using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Buisness.Abstract
{
  public  interface IBrandService
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);
        Brand GetById(int id);
    }
}
