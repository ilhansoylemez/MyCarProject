using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ColorManager : IColorService
    {
        IColorDal _colordate;
            public ColorManager(IColorDal colordate)
        {
            _colordate = colordate;
        }
        public Color GetCarsByBrandId(Color color)
        {

            return _colordate.Get(p => p.ColorId == color.ColorId);
        }
    }
}
