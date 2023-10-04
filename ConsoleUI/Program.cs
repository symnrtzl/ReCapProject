using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if(result.Success==true) 
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.UserFirstName + " " + user.UserLastName + "-" + user.Email + "-" + user.Password);

                }
            }

            Console.WriteLine("-----------------------------------------");

            
            CustomerManager customerManager=new CustomerManager(new EfCustomerDal());
            var result2=customerManager.GetById(1);
            if(result2.Success==true)
            {
                Console.WriteLine(result2.Data.CompanyName);
            }


        }

    }
}
