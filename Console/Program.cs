using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            Console.WriteLine("-----------------------------------");
            ColorTest();
            Console.WriteLine("-----------------------------------");
            BrandTest();
            RentalTest();
            Console.WriteLine("-----------------------------------");
            CustomerTest();
            Console.WriteLine("-----------------------------------");
            UserTest();
            Console.WriteLine("-----------------------------------");
            CustomerAdd();


        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer ();
            customer1.CustomerId =6;
            customer1.UserId = 5;
            customer1.CompanyName ="A";
            customerManager.Add(customer1);
            Console.WriteLine(Messages.CustomerAdded);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success == true)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.UserId+" / "+user.FirstName + " " + user.LastName+" / "+user.Email);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAll();

            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CustomerId + " / " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentalId+" / "+rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

                if (result.Success == true)
                {
                    foreach (var brand in result.Data)
                    {
                        Console.WriteLine(brand.BrandId+" / "+brand.BrandName);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

                if (result.Success == true)
                {
                    foreach (var color in result.Data)
                    {
                        Console.WriteLine(color.ColorId+" / "+color.ColorName);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + ") " + car.BrandName + " - " + car.ColorName + " featured car is only " + car.DailyPrice + "$ Please read the description if you want to rent a car for more than 1 day.");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }            
            
        }
    }
}
