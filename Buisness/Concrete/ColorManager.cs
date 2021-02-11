using System;
using System.Collections.Generic;
using System.Text;
using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Concrete
{
   public class ColorManager:IColorService
   {
       private IColorDal _colorDal;

       public ColorManager(IColorDal colorDal)
       {
           _colorDal = colorDal;
       }

       public List<Color> GetAll()
       {
           return _colorDal.GetAll();
       }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("RENK EKLENDİ");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
