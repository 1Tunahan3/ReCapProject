using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitize.Results;
using Entities.Concrete;

namespace Buisness.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();


        IDataResult<User> GetById(int id);


        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
