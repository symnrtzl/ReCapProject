using Business.Concrete;
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

            //GetAll
            CarManager carManager= new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }

            //GetById
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.ColorId);
            }


            //Add   
            CarManager carManager1 = new CarManager(new InMemoryCarDal());
            carManager1.Add(car1);
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description);
            }


            //Update
            carManager1.Update(car1);
            car1.Description = "Volvo Model";
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            //Delete
            carManager1.Delete(car1);
            foreach (var car in carManager1.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}
