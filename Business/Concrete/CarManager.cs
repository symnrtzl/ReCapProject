using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
            }
            else
            {
                throw new Exception("Daily Price ! 0'dan küçük ya da Açıklama 2 karakter değil");
            }
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c=>c.CarId== id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();

        }

        public List<Car> GetCarsByBrand(int brandId)
        {
            var result=_carDal.GetAll(c=> c.BrandId== brandId);
            return result;
        }

        public void GetCarsByBrandId(int id)
        {
            
            var cars = _carDal.GetAll(c => c.CarId == id);
            foreach (var car in cars)
            {
                Console.WriteLine(car.BrandId);
            }
        }

        public List<Car> GetCarsByColor(int colorId)
        {
            var result= _carDal.GetAll(c=> c.ColorId== colorId);
            return result;
        }

        public void GetCarsByColorId(int id)
        {
            var cars = _carDal.GetAll(c => c.CarId == id);
            foreach (var car in cars)
            {
                Console.WriteLine(car.ColorId);
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

    }

    
}
