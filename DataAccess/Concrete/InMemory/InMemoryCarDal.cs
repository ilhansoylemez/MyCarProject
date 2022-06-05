using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
        public class InMemoryCarDal : ICarDal
        {
            List<Car> _cars;

            public InMemoryCarDal()
            {
                _cars = new List<Car>() {

            new Car() {CarId=1, CarName="Clio", BrandId=1, ColorId=2, DailyPrice=50,Description="Old Car", ModelYear=2006 },
            new Car() {CarId=2, CarName="Megane", BrandId=2, ColorId=1, DailyPrice=100,Description="New Car", ModelYear=2020 }

            };
            }

            public void Add(Car Entity)
            {
                _cars.Add(Entity);
            }

            public void Delete(Car Entity)
            {

                foreach (var item in _cars)
                {
                    if (Entity.CarId == item.CarId)
                    {
                        _cars.Remove(item);
                    }
                }

            }

            public Car Get(Expression<Func<Car, bool>> filter = null)
            {
                throw new NotImplementedException();
            }

            public Car Get(int id)
            {
                Car ReferansNumber = new Car();
                foreach (var item in _cars)
                {
                    if (item.CarId == id)
                    {
                        ReferansNumber = item;
                    }
                }
                return ReferansNumber;
            }

            public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
            {
                throw new NotImplementedException();
            }
            public List<Car> GetAll(int id)
            {
                return _cars;
            }

        public List<CarDetailDto> getCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car Entity)
            {
                foreach (var item in _cars)
                {
                    if (Entity.CarId == item.CarId)
                    {
                        item.CarId = Entity.CarId;
                        item.CarName = Entity.CarName;
                        item.BrandId = Entity.BrandId;
                        item.ColorId = Entity.ColorId;
                        item.Description = Entity.Description;
                        item.ModelYear = Entity.ModelYear;
                        item.DailyPrice = Entity.DailyPrice;
                    }
                }
            }
        }
}
