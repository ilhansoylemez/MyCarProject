using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.DTOs;
using Core.Utilities;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal ıCarDal;


        public CarManager(ICarDal T)
        {
            ıCarDal = T;
        }

        public IResult Add(Car car)
        {
          if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                ıCarDal.Add(car);
                return new SuccessResult("Successful");
            }
          else
            {
                return new ErrorResult("Unsuccessful");
            }
            }

        

        public void Delete(Car car)
        {
            ıCarDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(55 == 55)
            {
                return new SuccessDataResult<List<Car>>("True");
            }
            else
            {
                return new ErrorDataResult<List<Car>>("Wrong");
            }
        }

        public List<Car> GetByBrandId(int id)
        {
            List<Car> BrandList = new List<Car>();

            foreach (var item in ıCarDal.GetAll())
            {
                if (item.BrandId == id)
                {
                    BrandList.Add(item);
                }
            }
            return BrandList;
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return ıCarDal.getCarDetail();
        }

        public void Update(Car car)
        {
            ıCarDal.Update(car);
        }

       
    }
}
