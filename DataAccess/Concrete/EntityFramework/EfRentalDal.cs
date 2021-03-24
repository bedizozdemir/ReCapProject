using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,SqlContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (SqlContext context = new SqlContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars 
                             on r.CarId equals ca.CarId
                             join b in context.Brands 
                             on ca.BrandId equals b.BrandId
                             join cu in context.Customers 
                             on r.CustomerId equals cu.CustomerId
                             join u in context.Users 
                             on cu.UserId equals u.UserId
                             select new RentalDetailDto { BrandName = b.BrandName, FirstName = u.FirstName, LastName = u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
            

        }
    }
}
