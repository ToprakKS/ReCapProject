using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cr in context.Cars
                             join b in context.Brands
                             on cr.BrandId equals b.BrandId
                             join clr in context.Colors
                             on cr.ColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 CarName = cr.Id,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = cr.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
