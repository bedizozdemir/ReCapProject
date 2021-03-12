using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SqlContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (SqlContext context = new SqlContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join c in context.Colors
                             on ca.ColorId equals c.ColorId
                             select new CarDetailDto {CarId=ca.CarId,BrandId=b.BrandId, ColorId=c.ColorId ,BrandName=b.BrandName, ColorName=c.ColorName,DailyPrice=ca.DailyPrice, Description=ca.Description, ModelYear=ca.ModelYear};
                return result.ToList();
            }
            
        }
    }
}
