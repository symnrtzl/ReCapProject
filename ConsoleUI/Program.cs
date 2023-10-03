using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if(result.Success==true) 
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);

                }
            }

            Console.WriteLine("-----------------------------------------");

            ColorManager colorManager=new ColorManager(new EfColorDal());
            var result2=colorManager.GetById(2);
            if(result2.Success==true)
            {
                Console.WriteLine(result2.Data.ColorName);
            }
            
        }

    }
}
