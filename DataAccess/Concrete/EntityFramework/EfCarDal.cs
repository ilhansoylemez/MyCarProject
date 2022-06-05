using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> getCarDetail()
        {
            using (CarContext carContext = new CarContext())
            {
                var result = from p in carContext.Cars
                             join c in carContext.Colors
                             on p.ColorId equals c.ColorId
                             join s in carContext.Brands on p.BrandId equals s.BrandId
                             select new CarDetailDto {CarName = p.CarName,  ColorName = c.ColorName,BrandName = s.BrandName, DailyPrice =p.DailyPrice };
                return result.ToList();
            }
            
        }
    }
}
