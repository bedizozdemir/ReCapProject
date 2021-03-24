using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCard> GetById(int id);
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IDataResult<CreditCard> Get(CreditCard creditCard);
    }
}
