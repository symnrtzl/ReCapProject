using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        List<Car> GetCarsByBrand(int brandId);
        List<Car> GetCarsByColor(int colorId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        void GetCarsByBrandId(int id);
        void GetCarsByColorId(int id);

    }
}
