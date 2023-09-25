using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId=1, BrandId=1, ColorId=1, DailyPrice=20000, ModelYear="2020", Description="Porsche Taycan"},
                new Car { CarId=2, BrandId=1, ColorId=4, DailyPrice=15000, ModelYear="2023", Description="Porsche Panamera"},
                new Car { CarId=3, BrandId=2, ColorId=5, DailyPrice=3000, ModelYear="2018", Description="BMW i7"},
                new Car { CarId=4, BrandId=2, ColorId=2, DailyPrice=6500, ModelYear="2016", Description="BMW M8 Gran Coupé"},
                new Car { CarId=5, BrandId=3, ColorId=3, DailyPrice=9000, ModelYear="2020", Description="Mercedes EQB"},
                new Car { CarId=6, BrandId=3, ColorId=1, DailyPrice=10000, ModelYear="2014", Description="Mercedes Maybach S Serisi"},
                new Car { CarId=7, BrandId=4, ColorId=6, DailyPrice=2000, ModelYear="2020", Description="Audi e-tron GT"},
                new Car { CarId=8, BrandId=4, ColorId=8, DailyPrice=6000, ModelYear="2022", Description="Audi Coupe"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p=>p.CarId== id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
    }
}
