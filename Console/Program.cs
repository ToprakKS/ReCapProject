using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if(result.Success == true)
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
