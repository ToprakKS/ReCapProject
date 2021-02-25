using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //UserTest();

            //CustomerTest();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(new Customer
            {
                CompanyName = "Amazon",
                UserId = 2
            }).Messages);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine(userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "Şimşek",
                Email = "ahmetsimsek",
                Password = "123afhdas"

            }).Messages);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.CarName + " / " + car.BrandName);
                }
            }
            else
            {
                System.Console.WriteLine(result.Messages);
            }
        }
    }
}
