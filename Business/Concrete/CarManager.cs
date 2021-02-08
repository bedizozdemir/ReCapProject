using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            //if etc.
            return _carDal.GetCarDetails();
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Car added.");
            }
            else
            {
                Console.WriteLine("You cannot enter 0 or less for DailyPrice. Please retry.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted.");

        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Car updated.");
            }
            else
            {
                Console.WriteLine("You cannot enter 0 or less for DailyPrice. Please retry.");
            }
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
