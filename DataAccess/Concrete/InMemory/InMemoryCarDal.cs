using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1, BrandId=1, ColorId=2, DailyPrice=1700, ModelYear=2019, Description=""},
                new Car {CarId=2, BrandId=3, ColorId=1, DailyPrice=800, ModelYear=2019, Description="Rent a Volkswagen"},
                new Car {CarId=3, BrandId=2, ColorId=1, DailyPrice=750, ModelYear=2020, Description="Rent an Opel"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandld(int brandId)
        {
            return _cars.Where(b=>b.BrandId==brandId).ToList();            
        }

        public List<Car> GetCarsByColorld(int colorId)
        {
            return _cars.Where(c=>c.ColorId==colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
