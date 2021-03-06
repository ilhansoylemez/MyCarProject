using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> getCarDetail();
    }
}
