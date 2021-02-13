﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitize.Results;
using Entities.Concrete;

namespace Buisness.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();


        IDataResult<Rental> GetById(int id);


        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

    }
}