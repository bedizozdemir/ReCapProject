using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental, DateTime date);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
