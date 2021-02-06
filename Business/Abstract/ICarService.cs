using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCarsByColorld(int colorId);
        List<Car> GetCarsByBrandld(int brandId);
        List<Car> GetAll();
       
    }
}
