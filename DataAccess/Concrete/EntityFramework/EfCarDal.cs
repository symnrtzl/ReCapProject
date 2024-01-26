using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto,bool>> filter = null)
        {
            using(RentCarDatabaseContext context = new RentCarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 ColorId = co.ColorId,
                                 BrandId = b.BrandId,
                                 ModelName=b.BrandModel,
                                 ImagePath=(from image in context.CarImages
                                            where image.CarId == c.CarId
                                            select image.ImagePath).FirstOrDefault()
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }



        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (RentCarDatabaseContext context = new RentCarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             where b.BrandId==brandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 ColorId= co.ColorId,
                                 BrandId = b.BrandId,
                                 ModelName = b.BrandModel,
                                 ImagePath = (from m in context.CarImages
                                              where m.CarId == c.CarId 
                                              select m.ImagePath).FirstOrDefault()

                             };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (RentCarDatabaseContext context = new RentCarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             where co.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 ColorId = co.ColorId,
                                 BrandId = b.BrandId,
                                 ModelName = b.BrandModel,
                                 ImagePath = (from m in context.CarImages
                                              where m.CarId == c.CarId 
                                              select m.ImagePath).FirstOrDefault()

                             };

                return result.ToList();
            }
        }
    }
}
