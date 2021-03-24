using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
        ICustomerService _customerService;
        IPaymentService _paymentService;
        public CreditCardManager(ICreditCardDal creditCardDal, ICustomerService customerService, IPaymentService paymentService)
        {
            _creditCardDal = creditCardDal;
            _paymentService = paymentService;
            _customerService = customerService;
        }
        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult("Credit Card" + Messages.Added);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult("Credit Card" + Messages.Deleted);
        }

        public IDataResult<CreditCard> Get(CreditCard creditCard)
        {
            return new SuccessDataResult<CreditCard>(_creditCardDal.Get(cc => cc.CreditCardId == creditCard.CreditCardId));
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            CreditCard creditCard = new CreditCard();
            if (_creditCardDal.GetAll().Any(cc => cc.CreditCardId == id))
            {
                creditCard = _creditCardDal.GetAll().FirstOrDefault(cc => cc.CreditCardId == id);
            }
            else Console.WriteLine(Messages.NotExist + "credit card");
            return new SuccessDataResult<CreditCard>(creditCard);
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult("Credit Card" + Messages.Updated);
        }
    }
}
