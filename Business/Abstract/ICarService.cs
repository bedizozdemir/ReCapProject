using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {        
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetAllCarDetailsByFilter(int brandId, int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car);
    }
}
