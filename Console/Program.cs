using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            Console.WriteLine("-----------------------------------");
            ColorTest();
            Console.WriteLine("-----------------------------------");
            BrandTest();                    

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId +" "+ brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId+" "+color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId+") "+car.BrandName+ " - " +car.ColorName+ " featured car is only "+ car.DailyPrice+"$ Please read the description if you want to rent a car for more than 1 day.");
            }


            
        }
    }
}
