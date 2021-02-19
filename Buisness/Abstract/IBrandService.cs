﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitize.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
  public  interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();

        IDataResult<Brand> GetById(int id);


        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);


       
    }
}
