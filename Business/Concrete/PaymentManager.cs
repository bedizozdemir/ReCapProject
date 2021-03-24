using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        ICustomerService _customerService;
        ICreditCardService _creditCardService;
        public PaymentManager(IPaymentDal paymentDal, ICustomerService customerService, ICreditCardService creditCardService)
        {
            _paymentDal = paymentDal;
            _creditCardService = creditCardService;
            _customerService = customerService;
        }
        public IResult Add(Payment payment)
        {
            IResult result = BusinessRules.Run(
                CheckIsCreditCardExist(payment.CreditCardNumber, payment.ExpirationDate, payment.CVV));

            if (result != null)
            {
                return result;
            }
            _paymentDal.Add(payment);

            return new SuccessResult("Payment" + Messages.Added);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult("Payment" + Messages.Deleted);
        }

        public IDataResult<Payment> Get(Payment payment)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p => p.PaymentId == payment.PaymentId));
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> GetById(int id)
        {
            Payment payment = new Payment();
            if (_paymentDal.GetAll().Any(p => p.PaymentId == id))
            {
                payment = _paymentDal.GetAll().FirstOrDefault(p => p.PaymentId == id);
            }
            else Console.WriteLine(Messages.NotExist + "payment");
            return new SuccessDataResult<Payment>(payment);
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult("Payment" + Messages.Updated);
        }
        private IResult CheckIsCreditCardExist(string cardNumber, string expirationDate, string cVV)
        {
            if (!_creditCardService.GetAll().Data.Any(
                cc => cc.CreditCardNumber == cardNumber &&
                cc.ExpirationDate == expirationDate &&
                cc.CVV == cVV
                ))
            {
                return new ErrorResult(Messages.NotExist + "credit card");
            }
            return new SuccessResult();
        }
    }
}
