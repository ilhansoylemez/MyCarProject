using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        public IResult Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);
        public List<Car> GetByBrandId(int id);

        public List<CarDetailDto> GetCarDetail();
        public IDataResult<List<Car>> GetAll();
    }
}
