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
            Car car1 = new Car { CarId = 9, BrandId = 9, ColorId = 10, DailyPrice = 6000, ModelYear = "2022", Description = "Volvo S60" };

            CarManager productManager = new CarManager(new EfCarDal());
            productManager.GetCarsByBrandId();


        }
    }
}
