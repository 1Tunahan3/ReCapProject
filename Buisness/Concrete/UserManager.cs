﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Business.Abstract;
using Core.Utilitize.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class UserManager:IUserService
   {
       private IUserDal _userDal;

       public UserManager(IUserDal userDal)
       {
           _userDal = userDal;
       }


       public IDataResult<List<User>> GetAll()
        {
           return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==id));
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccesResult(Messages.CarAdded);
        }

        public IResult Delete(User user)
        {

            _userDal.Delete(user);
            return new SuccesResult();

        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
           return new SuccesResult();
        }
    }
}
