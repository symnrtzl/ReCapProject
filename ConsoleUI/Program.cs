using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " - " + car.BrandName + " - " + car.ColorName);
            }

        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /*
            foreach(var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

            Console.WriteLine("--------------------------");
            foreach (var c in carManager.GetById(3))
            {
                Console.WriteLine(c.Description);
            }

            */

            /*
            carManager.GetCarsByBrandId(4);
            carManager.GetCarsByColorId(4);

            carManager.Add(new Car {  BrandId = 20, ColorId = 2, ModelYear = "2016", DailyPrice = 0, Description = "----" });//Hata İşlemleri tamamlandı
            */


            foreach (var c in carManager.GetCarsByBrand(22))
            {
                Console.WriteLine(c.CarId);
            }

            foreach (var c in carManager.GetCarsByColor(2))
            {
                Console.WriteLine(c.CarId);
            }
        }
    }
}
